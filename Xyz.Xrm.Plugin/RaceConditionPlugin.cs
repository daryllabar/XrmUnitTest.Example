using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using DLaB.Xrm;
using DLaB.Xrm.Plugin;
using Xyz.Xrm.Entities;

namespace Xyz.Xrm.Plugin
{
    /// <summary>
    /// Example of what not to do with plugins.
    /// This plugin is supposed to run on update of a contact's email address.
    ///   If the account for the contact has no primary contact, it is set to the contact
    ///   If the primary contact of the account is this contact, then the email address will be updated.
    /// </summary>
    // ReSharper disable once RedundantExtendsListEntry
    public class RaceConditionPlugin : PluginBase, IPlugin
    {
        /// <summary>
        /// THIS IS BAD!!!!  It introduces a race condition!!!!
        /// </summary>
        private Account Account { get; set; }

        #region Constructors

        public RaceConditionPlugin(string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig) { }

        #endregion Constructors

        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PostOperation, MessageType.Update)
                   .ForEntities<Contact>().Build();
        }

        protected override void ExecuteInternal(ExtendedPluginContext context)
        {
            var preImage = context.GetPreEntity<Contact>();
            var target = context.CoalesceTargetWithPreEntity<Contact>();
            if (preImage.EmailAddress1 == target.EmailAddress1)
            {
                context.Trace("Email Address 1 didn't change.  Exiting.");
                return;
            }

            if (target.AccountId == null)
            {
                context.Trace("No Account for Contact.  Exiting.");
                return;
            }

            InitializeAccount(context, target);
            if (Account.PrimaryContactId == null)  // Account could have been changed by a new thread.
            {
                SetContactToPrimary(context);
            }
            else if (Account.PrimaryContactId?.Id != context.PrimaryEntityId) // Account could have changed, which could result in this being true, when it shouldn't.
            {
                context.Trace("Contact is not primary contact of the account.  Exiting.");
                return;
            }

            UpdateAccountEmail(context, target);

        }

        private void InitializeAccount(ExtendedPluginContext context, Contact target)
        {
            var account = context.OrganizationService.GetEntity<Account>(target.AccountId.Id, a => new { a.AccountId, a.PrimaryContactId});
            Account = account; // This line starts the race condition
        }

        private void SetContactToPrimary(ExtendedPluginContext context)
        {
            context.OrganizationService.Update(new Account
            {
                Id = Account.Id, // Account could have been changed by a new thread.
                PrimaryContactId = context.PrimaryEntity
            });
        }

        private void UpdateAccountEmail(ExtendedPluginContext context, Contact target)
        {
            context.OrganizationService.Update(new Account
            {
                Id = Account.Id, // Account could have been changed by a new thread.
                EmailAddress1 = target.EmailAddress1
            });
        }
    }
}

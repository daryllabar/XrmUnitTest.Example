using System;
using System.Collections.Generic;
using System.Linq;
using Xyz.Xrm.Entities;
using Source.DLaB.Xrm.Plugin;
using Microsoft.Xrm.Sdk;
using Source.DLaB.Xrm.Ioc;

namespace Xyz.Xrm.Plugin
{
    /// <summary>
    /// Class to Sync a Contact's Address Information to the Account, if it is the primary account
    /// </summary>
    public class SyncContactToAccount : PluginBase, IPlugin
    {
        public const string AddressNotUpdatedMessage = "Address not updated, no need to update Account.";

        #region Constructors

        public SyncContactToAccount(string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig) { }
        public SyncContactToAccount(IIocContainer container, string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig, container) { }

        #endregion Constructors

        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PreOperation, MessageType.Create, MessageType.Update)
                .ForEntities<Contact>()
                .WithExecuteAction(OnUserEmailRouterAccessApproved)
                .WithValidator(new RequirementValidator()
                    .Updated(new SystemUser { EmailRouterAccessApproval = SystemUser_EmailRouterAccessApproval.Approved }))

                .WithAssertValidator(new RequirementValidator()
                        .Contains<Contact>(ContextEntity.CoalesceTargetPreImage, c => new { c.FullName, c.EMailAddress1 }),
                    "Name and Email address are required to notify admin of email router access approval!")
                .Build();
        }

        protected void OnUserEmailRouterAccessApproved(ExtendedPluginContext context) { }

        protected override void ExecuteInternal(ExtendedPluginContext context)
        {
            // Get the Target
            var contact = context.GetTarget<Contact>();

            // No Need to check for the address line 1 being updated since the Requirement Validator does that
            // if (string.IsNullOrWhiteSpace(contact.Address1_Line1))
            // {
            //     context.Trace(AddressNotUpdatedMessage);
            //     return;
            // }

            using (var crm = new CdsContext(context.OrganizationService))
            {
                var accounts = crm.AccountSet.Where(a => a.PrimaryContactId.Id == contact.Id);
                foreach (var account in accounts)
                {
                    UpdateAccountAddress(context.OrganizationService, account.Id, contact);
                }
            }
        }

        private void UpdateAccountAddress(IOrganizationService service, Guid id, Contact contact)
        {
            var account = new Account
            {
                Address1_Line1 = contact.Address1_Line1,
                Address1_Line2 = contact.Address1_Line2,
                Address1_Line3 = contact.Address1_Line3,
                Address1_AddressTypeCode = (Account_Address1_AddressTypeCode?)contact.Address1_AddressTypeCode,
                Address1_City = contact.Address1_City,
                Address1_Country = contact.Address1_Country,
                Address1_County = contact.Address1_County,
                Address1_StateOrProvince = contact.Address1_StateOrProvince,
                Address1_Name = contact.Address1_Name,
                Address1_PostalCode = contact.Address1_PostalCode,
                Id = id
            };

            service.Update(account);
        }
    }
}
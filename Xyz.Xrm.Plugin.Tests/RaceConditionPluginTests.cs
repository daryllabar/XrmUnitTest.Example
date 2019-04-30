// ReSharper disable ConvertToConstant.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalse
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DLaB.Xrm;
using DLaB.Xrm.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Xyz.Xrm.Entities;
using Xyz.Xrm.Test;
using Xyz.Xrm.Test.Builders;

namespace Xyz.Xrm.Plugin.Tests
{
    [TestClass]
    public class RaceConditionPluginTests
    {
        #region MultiThreadedCall_Should_CauseRaceCondition

        [TestMethod]
        public void RaceConditionPlugin_MultiThreadedCall_Should_CauseRaceCondition()
        {
            new MultiThreadedCall_Should_CauseRaceCondition().Test();
        }

        private class MultiThreadedCall_Should_CauseRaceCondition : TestMethodClassBase
        {
            private struct Ids
            {
                public struct Accounts
                {
                    public static readonly Id<Account> A = new Id<Account>("B0A7FF5F-229A-4A3E-AB43-84EB354FB45B");
                    public static readonly Id<Account> B = new Id<Account>("BD04A11B-2A89-4D4F-808D-DCDF7A66F379");
                    public static readonly Id<Account> C = new Id<Account>("671B18BC-15B8-4E77-B15C-9B2B5CC4F874");
                    public static readonly Id<Account> D = new Id<Account>("48512432-C4D0-42AC-BE98-F1B7ACF0845C");
                    public static readonly Id<Account> E = new Id<Account>("D5F3D920-9DD8-406A-B39E-38AAD816043E");
                    public static readonly Id<Account> F = new Id<Account>("EA63E2DE-2ED7-47C2-99CE-3F957EF617CA");
                    public static readonly Id<Account> G = new Id<Account>("B97E5FE5-AF76-44CB-AA10-93A55A8E2BA5");
                    public static readonly Id<Account> H = new Id<Account>("4D9CBAAB-E55C-4697-9473-5F575C12663B");
                    public static readonly Id<Account> I = new Id<Account>("5BFCC860-1AAA-42E2-B517-919A08996E25");
                    public static readonly Id<Account> J = new Id<Account>("98707235-E37F-4056-A0B3-755B035EB216");
                }
                public struct Contacts
                {
                    public static readonly Id<Contact> A = new Id<Contact>("61C714C6-1725-4B12-A6A7-F5A83B387897");
                    public static readonly Id<Contact> B = new Id<Contact>("11E79D5E-5679-4CE0-9FF1-12D7075C9721");
                    public static readonly Id<Contact> C = new Id<Contact>("D842D77B-4AF1-4C0D-BD3C-C3B850452D61");
                    public static readonly Id<Contact> D = new Id<Contact>("1AF9792F-AB28-4343-8E63-85EE7E2051C9");
                    public static readonly Id<Contact> E = new Id<Contact>("887490AE-AD19-4BF2-928B-E8698C0956A7");
                    public static readonly Id<Contact> F = new Id<Contact>("9307D121-DEB4-45AF-B7EE-1913E1A67C76");
                    public static readonly Id<Contact> G = new Id<Contact>("2239CE90-D4F5-4EED-9E59-E93A878CDE5F");
                    public static readonly Id<Contact> H = new Id<Contact>("35B20FAE-E088-40A3-B00F-CAA6682B5414");
                    public static readonly Id<Contact> I = new Id<Contact>("9ADF7244-79B4-4620-AA71-FECFB8F8A62E");
                    public static readonly Id<Contact> J = new Id<Contact>("66F12ACE-68C6-4BB6-BA2C-09916A3D87A1");
                }
            }

            protected override void InitializeTestData(IOrganizationService service)
            {
                new CrmEnvironmentBuilder()
                    .WithChildEntities(Ids.Accounts.A, Ids.Contacts.A)
                    .WithChildEntities(Ids.Accounts.B, Ids.Contacts.B)
                    .WithChildEntities(Ids.Accounts.C, Ids.Contacts.C)
                    .WithChildEntities(Ids.Accounts.D, Ids.Contacts.D)
                    .WithChildEntities(Ids.Accounts.E, Ids.Contacts.E)
                    .WithChildEntities(Ids.Accounts.F, Ids.Contacts.F)
                    .WithChildEntities(Ids.Accounts.G, Ids.Contacts.G)
                    .WithChildEntities(Ids.Accounts.H, Ids.Contacts.H)
                    .WithChildEntities(Ids.Accounts.I, Ids.Contacts.I)
                    .WithChildEntities(Ids.Accounts.J, Ids.Contacts.J)
                    .Create(service);
            }

            protected override void Test(IOrganizationService service)
            {

                //
                // Arrange
                //
                // The CRM server will create one instance of your plugin, and then run it, multi-threaded,
                // so here we setup all the contexts, and call them potentially multi-threaded, on a single plugin
                var plugin = new RaceConditionPlugin();

                var builder = new PluginExecutionContextBuilder()
                              .WithFirstRegisteredEvent(plugin)
                              .WithPrimaryEntityName(Contact.EntityLogicalName)
                              .WithPreImage(new Contact());
                var providers = new List<IServiceProvider>();
                foreach (var contact in EntityIdsByLogicalName[Contact.EntityLogicalName].Cast<Id<Contact>>())
                {
                    var context = builder.WithTarget(new Contact
                        {
                            EMailAddress1 = contact.EntityId + "@test.com",
                            [Contact.Fields.AccountId] = contact.Entity.ParentCustomerId
                        })
                        .WithPrimaryEntityId(contact)
                        .Build();

                    providers.Add(new ServiceProviderBuilder(service, context, Logger).Build());
                }

                //
                // Act
                //
                var inParallel = false;
                Execute(providers, plugin, inParallel); 

                //
                // Assert
                //
                var raceConditionFailures = new List<string>();
                foreach (var account in service.GetEntitiesById<Account>(EntityIdsByLogicalName[Account.EntityLogicalName].Select(a => a.EntityId)))
                {

                    if (account.EMailAddress1 == null)
                    {
                        raceConditionFailures.Add($"Account {account.Id} should have had it's email set to it's contact's email but didn't.");
                    }

                    if (account.PrimaryContactId == null)
                    {
                        raceConditionFailures.Add($"Account {account.Id} should have had it's PrimaryContactId set to it's contact's id but didn't.");
                    }
                }

                var failures = string.Join(Environment.NewLine, raceConditionFailures);
                Assert.IsTrue(string.IsNullOrEmpty(failures), "No failures should have occured, but the following were found:" + Environment.NewLine + failures);
            }

            private static void Execute(List<IServiceProvider> providers, RaceConditionPlugin plugin, bool inParallel)
            {
                if (inParallel)
                {
                    Parallel.ForEach(providers, p => { plugin.Execute(p); });
                }
                else
                {
                    foreach (var provider in providers)
                    {
                        plugin.Execute(provider);
                    }
                }
            }
        }

        #endregion MultiThreadedCall_Should_CauseRaceCondition
    }
}

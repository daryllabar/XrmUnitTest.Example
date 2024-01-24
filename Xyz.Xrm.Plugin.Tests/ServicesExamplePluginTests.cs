using DLaB.Xrm.Test.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Xyz.Xrm.Entities;

namespace Xyz.Xrm.Plugin.Tests
{
    [TestClass]
    public class ServicesExamplePluginTests
    {
        private ServicesExamplePlugin _sut;
        private MockServicesExampleData _data;

        [TestInitialize]
        public void Initialize()
        {
            _data = new MockServicesExampleData();
            _sut = new ServicesExamplePlugin();
            _sut.Container.AddScoped<IServicesExampleData>(s => _data);
        }

        [TestMethod]
        public void ExamplePluginTestWithoutTestingDataverseAccess()
        {
            //
            // Arrange
            //
            var mainContact = new Contact
            {
                Id = Guid.NewGuid(),
                LastName = "Smith"
            };
            var context= new PluginExecutionContextBuilder()
                .WithTarget(mainContact)
                .Build();
            var serviceProvider = new ServiceProviderBuilder(null, context).Build();
            
            //
            // Act
            //
            _sut.Execute(serviceProvider);

            //
            // Assert
            //
            Assert.AreEqual(mainContact.LastName, _data.LastName);
            Assert.AreEqual(mainContact.Id, _data.MainContact.Id);
            Assert.AreEqual(_data.UpdatedContacts.Count, _data.Dependents.Count);
            foreach (var expectedContact in _data.Dependents)
            {
                Assert.IsNotNull(_data.UpdatedContacts.Single(c => c.Id == expectedContact.Id));
            }
        }
    }

    /// <summary>
    /// Don't do this.  Use your favorite mocking framework to mock and verify these for testing
    /// </summary>
    public class MockServicesExampleData : IServicesExampleData
    {
        public List<Contact> Dependents { get; set; } = new List<Contact>
        {
            new Contact{ FirstName = "1", Id = Guid.NewGuid()},
            new Contact{ FirstName = "2", Id = Guid.NewGuid()},
            new Contact{ FirstName = "3", Id = Guid.NewGuid()},
        };
        public string LastName { get; private set; }
        public Contact MainContact { get; private set; }
        public List<Contact> UpdatedContacts { get; private set; }

        public List<Contact> GetDependents(string lastName)
        {
            LastName = lastName;
            return Dependents;
        }

        public void SyncAndUpdateAddresses(Contact main, List<Contact> dependents)
        {
            MainContact = main;
            UpdatedContacts = dependents;
        }
}
}

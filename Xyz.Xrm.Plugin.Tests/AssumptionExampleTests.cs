using DLaB.Xrm;
using Xyz.Xrm.Test;
using Xyz.Xrm.Test.Assumptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Xyz.Xrm.Entities;

namespace Xyz.Xrm.Plugin.Tests
{
    [TestClass]
    public class AssumptionExampleTests
    {
        #region PowerAppsChecker_Should_Exist

        [TestMethod]
        public void AssumptionExample_PowerAppsChecker_Should_Exist()
        {
            new PowerAppsChecker_Should_Exist().Test();
        }

        [User_PowerAppsChecker] // Assumption Attribute
        private class PowerAppsChecker_Should_Exist : TestMethodClassBase
        {
            protected override void Test(IOrganizationService service)
            {
                //
                // Act
                //
                var user = AssumedEntities.Get(new User_PowerAppsChecker());
                var userName = service.GetEntity<SystemUser>(user.Id).DomainName;

                //
                // Assert
                //
                Assert.IsNotNull(user.DomainName);
                Assert.AreEqual(user.DomainName, userName);
            }
        }

        #endregion PowerAppsChecker_Should_Exist
    }
}
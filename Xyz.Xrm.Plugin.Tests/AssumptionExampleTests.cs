﻿using DLaB.Xrm;
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
        #region InstallProduct_Should_ContainDescription

        [TestMethod]
        public void AssumptionExample_InstallProduct_Should_ContainDescription()
        {
            new InstallProduct_Should_ContainDescription().Test();
        }

        [Product_Install] // Assumption Attribute
        private class InstallProduct_Should_ContainDescription : TestMethodClassBase
        {
            protected override void Test(IOrganizationService service)
            {
                //
                // Act
                //
                var product = AssumedEntities.Get(new Product_Install());
                var description = service.GetEntity<Product>(product.Id).Description;

                //
                // Assert
                //
                Assert.IsNotNull(product.Description);
                Assert.AreEqual(product.Description, description);
            }
        }

        #endregion InstallProduct_Should_ContainDescription
    }
}
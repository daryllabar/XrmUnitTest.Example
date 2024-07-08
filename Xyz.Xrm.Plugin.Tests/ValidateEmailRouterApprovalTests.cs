using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Xyz.Xrm.Entities;
using Xyz.Xrm.Test;
using Xyz.Xrm.Test.Builders;


namespace Xyz.Xrm.Plugin.Tests
{

    [TestClass]
    public class ValidateEmailRouterApprovalTests
    {
        [TestMethod]
        public void ValidateEmailRouterApproval_OnRouterAccessApproved_Should_RequireMobile()
        {

            //
            // Arrange
            //
            var plugin = new ValidateEmailRouterApproval();
            var context = new PluginExecutionContextBuilder().WithFirstRegisteredEvent(plugin)
                .WithTarget(new SystemUser
                {
                    EmailRouterAccessApproval = SystemUser_EmailRouterAccessApproval.Approved,
                }).Build();
            var serviceProvider = new ServiceProviderBuilder(null, context, new DebugLogger()).Build();

            //
            // Act
            //
            InvalidPluginExecutionException ex = null;
            try
            {
                plugin.Execute(serviceProvider);
            }
            catch (InvalidPluginExecutionException exception)
            {
                ex = exception;
            }

            //
            // Assert
            //
            Assert.IsNotNull(ex, "Plugin should have thrown an exception!");
            Assert.AreEqual(ValidateEmailRouterApproval.MobileRequired, ex.Message);
        }
    }
}

using DLaB.Xrm.Test;
using DLaB.Xrm.Test.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Source.DLaB.Xrm.Ioc;
using System;
using System.Linq;
using Xyz.Xrm.Test;

namespace Xyz.Xrm.Workflow.Tests
{
    /// <summary>
    /// Workflow Example.  Utilizes the WorkflowInvokerBuilder to Invoke the workflow
    /// </summary>
    [TestClass]
    public class WorkflowActivityExampleTests
    {
        [TestMethod]
        public void CreateGuidActivity_Request_Should_CreateGuid()
        {
            //
            // Arrange
            //
            TestInitializer.InitializeTestSettings();

            var overrides = new IocContainer();
            overrides.AddScoped<ITracingService>(s => new FakeTraceService(new DebugLogger()));

            var workflow = new CreateGuidActivity(new IocContainer
            {
                PreBuildServiceProviderOverrideRegistrations = overrides
            });

            //
            // Act
            //
            var results = new WorkflowInvokerBuilder(workflow).
                // WithService(service).
                InvokeWorkflow();
            //
            // Assert
            //
            Assert.IsTrue(Guid.TryParse(results.First().Value.ToString(), out _));
        }
    }
}
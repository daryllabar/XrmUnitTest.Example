using DLaB.Xrm.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using Xyz.Xrm.Test;
using Xyz.Xrm.Test.Builders;

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

            var workflow = new CreateGuidActivity();
            workflow.Container.AddScoped<ITracingService>(s => new FakeTraceService(new DebugLogger()));

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
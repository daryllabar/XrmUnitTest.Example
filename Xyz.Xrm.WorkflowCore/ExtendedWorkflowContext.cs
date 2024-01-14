using System;
using System.Activities;
using Source.DLaB.Xrm.Workflow;

namespace Xyz.Xrm.Workflow
{
    public class ExtendedWorkflowContext: DLaBExtendedWorkflowContext
    {
        public ExtendedWorkflowContext(IServiceProvider serviceProvider, CodeActivityContext executionContext, CodeActivity codeActivity) 
            : base(serviceProvider, executionContext, codeActivity)
        {
        }
    }
}

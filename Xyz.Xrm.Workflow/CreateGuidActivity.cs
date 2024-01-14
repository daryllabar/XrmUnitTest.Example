using Microsoft.Xrm.Sdk.Workflow;
using Source.DLaB.Xrm.Ioc;
using System;
using System.Activities;

namespace Xyz.Xrm.Workflow
{
    public class CreateGuidActivity : CodeActivityBase
    {
        [Output("Guid")]
        public OutArgument<string> Guid { get; set; }

        public CreateGuidActivity() : this(null) { }
        public CreateGuidActivity(IIocContainer container) : base(container) { }

        protected override void Execute(ExtendedWorkflowContext context, IServiceProvider serviceProvider)
        {
            Guid.Set(context, System.Guid.NewGuid().ToString());
        }
    }
}
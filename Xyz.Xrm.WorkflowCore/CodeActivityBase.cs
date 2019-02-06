using System.Activities;
using Source.DLaB.Xrm.Workflow;

namespace Xyz.Xrm.Workflow
{
    public abstract class CodeActivityBase : DLaBCodeActivityBase
    {
        #region Overrides of DLaBCodeActivityBase

        protected override IExtendedWorkflowContext CreateWorkflowContext(CodeActivityContext context)
        {
            return new ExtendedWorkflowContext(context, this);
        }

        protected sealed override void Execute(IExtendedWorkflowContext context)
        {
            Execute((ExtendedWorkflowContext)context);
        }

        #endregion

        protected abstract void Execute(ExtendedWorkflowContext context);
    }
}

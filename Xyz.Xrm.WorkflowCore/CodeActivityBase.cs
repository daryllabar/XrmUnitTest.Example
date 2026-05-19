using Source.DLaB.Xrm.Ioc;
using Source.DLaB.Xrm.Workflow;

namespace Xyz.Xrm.Workflow
{
    public abstract class CodeActivityBase : DLaBCodeActivityBase
    {
        protected CodeActivityBase(IIocContainer container) : base(container) { }

        #region Overrides of DLaBCodeActivityBase

        protected override IIocContainer RegisterServices(IIocContainer container)
        {
            return base.RegisterServices(container)
                .RegisterWorkflowDefaults();
        }

        #endregion
    }
}

using Source.DLaB.Xrm.Ioc;
using Source.DLaB.Xrm.Plugin;

namespace Xyz.Xrm.Plugin
{
    /// <summary>
    /// Every Plugin Should inherit directly or indirectly from this class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class GenericPluginBase<T> : DLaBGenericPluginBase<T> where T: ExtendedPluginContext
    {
        /// <inheritdoc />
        protected GenericPluginBase(string unsecureConfig, string secureConfig, IIocContainer container = null) : base(unsecureConfig, secureConfig, container) { }

        protected override IIocContainer RegisterServices(IIocContainer container)
        {
            return base.RegisterServices(container)
                .RegisterDefaultServices();
        }
    }
}

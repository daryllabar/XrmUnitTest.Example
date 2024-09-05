using DLaB.Xrm.Ioc;

namespace Xyz.Xrm.Plugin
{
    public abstract class PluginBase : GenericPluginBase<ExtendedPluginContext>
    {
        /// <inheritdoc />
        protected PluginBase(string unsecureConfig, string secureConfig, IIocContainer container = null) : base(unsecureConfig, secureConfig, container) { }
    }
}

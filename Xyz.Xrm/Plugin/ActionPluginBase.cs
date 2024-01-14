using Source.DLaB.Xrm.Ioc;

namespace Xyz.Xrm.Plugin
{
    public abstract class ActionPluginBase<TRequest, TResponse> : GenericPluginBase<ActionContext<TRequest, TResponse>>
        where TRequest : Microsoft.Xrm.Sdk.OrganizationRequest, new() 
        where TResponse : Microsoft.Xrm.Sdk.OrganizationResponse, new()
    {
        /// <inheritdoc />
        protected ActionPluginBase(string unsecureConfig, string secureConfig, IIocContainer container = null) : base(unsecureConfig, secureConfig, container) { }
    }
}

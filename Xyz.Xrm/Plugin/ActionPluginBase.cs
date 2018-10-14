using System;

namespace Xyz.Xrm.Plugin
{
    public abstract class ActionPluginBase<TRequest, TResponse> : GenericPluginBase<ActionContext<TRequest, TResponse>>
        where TRequest : Microsoft.Xrm.Sdk.OrganizationRequest, new() 
        where TResponse : Microsoft.Xrm.Sdk.OrganizationResponse, new()
    {
        /// <inheritdoc />
        protected ActionPluginBase(string unsecureConfig, string secureConfig) : base(unsecureConfig,secureConfig) { }

        /// <inheritdoc />
        protected override ActionContext<TRequest, TResponse> CreatePluginContext(IServiceProvider serviceProvider)
        {
            return new ActionContext<TRequest, TResponse>(serviceProvider, this);
        }
    }
}

using System;
using Source.DLaB.Xrm.Plugin;

namespace Xyz.Xrm.Plugin
{
    public class ActionContext<TRequest, TResponse> : ExtendedPluginContext
        where TRequest : Microsoft.Xrm.Sdk.OrganizationRequest, new() 
        where TResponse : Microsoft.Xrm.Sdk.OrganizationResponse, new()
    {
        public TRequest Request { get; set; }
        public TResponse Response { get; set; }
        public ActionContext(IServiceProvider serviceProvider, IRegisteredEventsPlugin plugin) : base(serviceProvider, plugin)
        {
            Request = new TRequest
            {
                Parameters = PluginExecutionContext.InputParameters
            };
            Response = new TResponse
            {
                Results = PluginExecutionContext.OutputParameters
            };
        }
    }
}

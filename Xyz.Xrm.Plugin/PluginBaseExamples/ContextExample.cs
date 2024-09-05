using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using DLaB.Xrm.Plugin;
// ReSharper disable UnusedVariable

namespace Xyz.Xrm.Plugin.PluginBaseExamples
{
    /// <summary>
    /// Shows hows the ExtendedPluginContext Hides Instantiation
    /// </summary>
    public class ContextExample : PluginBase, IPlugin
    {
        protected override void ExecuteInternal(ExtendedPluginContext context)
        {
            var systemService = context.SystemOrganizationService;
            var userService = context.OrganizationService;
            var initiatingService = context.InitiatingUserOrganizationService;
            ITracingService tracingService = context;
            IPluginExecutionContext pluginContext = context;

            /***************************
		     *    Plugin Logic Here    *
		     ***************************/
        }
        
        #region Constructors

        public ContextExample(string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig) { }

        #endregion Constructors

        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PreOperation, MessageType.Update).Build();
        }
    }

}

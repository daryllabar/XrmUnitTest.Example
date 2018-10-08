using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Source.DLaB.Xrm.Plugin;

namespace Xyz.Xrm.Plugin.PluginBaseExamples
{

    /// <summary>
    /// Shows hows the ExtendedPluginContext Hides Instantation
    /// </summary>
    public class ContextExample : PluginBase, IPlugin
    {
        protected override void ExecuteInternal(ExtendedPluginContext context)
        {
            var systemService = context.SystemOrganizationService;
            var userService = context.OrganizationService;
            var initiatingService = context.InitiatingUserOrganizationService;
            ITracingService tracignService = context;
            IPluginExecutionContext pluginContext = context;

            /***************************
		     *    Plugin Logic Here    *
		     ***************************/
        }
        
        #region Constructors

        public ContextExample() : this(null, null) { }
        public ContextExample(string unsecureConfig, string secureConfig) : base(unsecureConfig, secureConfig) { }

        #endregion Constructors

        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PreOperation, MessageType.Update).Build();
        }
    }

}

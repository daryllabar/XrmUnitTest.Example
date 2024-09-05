using System;
using System.Linq;
using DLaB.Xrm.Plugin;

namespace Xyz.Xrm.Test.Builders
{
    public class PluginExecutionContextBuilder : DLaB.Xrm.Test.Builders.PluginExecutionContextBuilderBase<PluginExecutionContextBuilder>
    {
        protected override PluginExecutionContextBuilder This => this;


        #region Fluent Methods

        /// <summary>
        /// Sets the first registered pre operation event of the plugin for the context.
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public PluginExecutionContextBuilder WithFirstPreOpEvent(IRegisteredEventsPlugin plugin)
        {
            var first = plugin.RegisteredEvents.FirstOrDefault(e => (int)e.Stage == (int)PipelineStage.PreOperation);
            AssertEventFound(plugin, first, "does not contain any pre operation registered events!");
            return WithRegisteredEvent(first);
        }

        /// <summary>
        /// Sets the first registered pre validation event of the plugin for the context.
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public PluginExecutionContextBuilder WithFirstPreValidationEvent(IRegisteredEventsPlugin plugin)
        {
            var first = plugin.RegisteredEvents.FirstOrDefault(e => (int)e.Stage == (int)PipelineStage.PreValidation);
            AssertEventFound(plugin, first, "does not contain any pre validation operation registered events!");
            return WithRegisteredEvent(first);
        }

        /// <summary>
        /// Sets the first registered post operation event of the plugin for the context.
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public PluginExecutionContextBuilder WithFirstPostOpEvent(IRegisteredEventsPlugin plugin)
        {
            var first = plugin.RegisteredEvents.FirstOrDefault(e => (int)e.Stage == (int)PipelineStage.PostOperation);
            AssertEventFound(plugin, first, "does not contain any post operation registered events!");
            return WithRegisteredEvent(first);
        }

        /// <summary>
        /// Sets the first registered event of the plugin for the context.
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public PluginExecutionContextBuilder WithFirstRegisteredEvent(IRegisteredEventsPlugin plugin)
        {
            var first = plugin.RegisteredEvents.FirstOrDefault();
            AssertEventFound(plugin, first, "does not contain any registered events!");
            return WithRegisteredEvent(first);
        }

        // ReSharper disable once ParameterOnlyUsedForPreconditionCheck.Local
        private void AssertEventFound(IRegisteredEventsPlugin plugin, RegisteredEvent @event, string message)
        {
            if (@event == null)
            {
                throw new Exception($"Plugin {plugin.GetType().FullName} {message}  Unable to set the registered event of the context.");
            }
        }

        #endregion Fluent Methods
    }
}

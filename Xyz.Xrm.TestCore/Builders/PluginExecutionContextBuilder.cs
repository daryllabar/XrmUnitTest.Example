using System;
using System.Linq;
using Source.DLaB.Xrm.Plugin;

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

        /// <summary>
        /// Sets the registered event for the context.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public PluginExecutionContextBuilder WithRegisteredEvent(RegisteredEvent @event)
        {
            return WithRegisteredEvent((int)@event.Stage, @event.MessageName, @event.EntityLogicalName);
        }

        /// <summary>
        /// Asserts that the plugin has only a single registered event, and sets it as the registered event for the context.
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public PluginExecutionContextBuilder WithRegisteredEvent(IRegisteredEventsPlugin plugin)
        {
            if (!plugin.RegisteredEvents.Any())
            {
                throw new Exception("Plugin " + plugin.GetType().FullName + " does not contain any registered events!  Unable to set the registered event of the context.");
            }
            if (plugin.RegisteredEvents.Skip(1).Any())
            {
                throw new Exception("Plugin " + plugin.GetType().FullName + " contains more than one registered event!  Unable to determine what registered event to use for the context.");
            }
            return WithRegisteredEvent(plugin.RegisteredEvents.Single());
        }


        /// <summary>
        /// Sets the IsolationMode of the Context.  This does not actually prevent Sandbox calls from being made.
        /// </summary>
        /// <param name="mode">The mode.</param>
        /// <returns></returns>
        public PluginExecutionContextBuilder WithIsolationMode(IsolationMode mode)
        {
            Context.IsolationMode = (int)mode;
            return this;
        }

        #endregion Fluent Methods
    }
}

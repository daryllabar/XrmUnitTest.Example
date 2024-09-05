using System;
using DLaB.Xrm.Ioc;
using DLaB.Xrm.Plugin;

namespace Xyz.Xrm.Plugin
{
    public static class Extensions
    {
        #region IocContainer

        public static IIocContainer RegisterDefaultServices(this IIocContainer container)
        {
            // Register any custom services here
            return container;
        }

        #endregion IocContainer

        #region RegisteredEventBuilder

        // Create Extension Method to Accept the Custom PluginContext

        public static RegisteredEventBuilder WithExecuteAction(this RegisteredEventBuilder builder, Action<ExtendedPluginContext> execute)
        {
            builder.WithExecuteAction(execute);
            return builder;
        }

        #endregion RegisteredEventBuilder
    }
}

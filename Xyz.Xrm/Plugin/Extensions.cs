using System;
using DLaB.Xrm;
using DLaB.Xrm.Ioc;
using DLaB.Xrm.Plugin;
using Xyz.Xrm.Entities;

namespace Xyz.Xrm.Plugin
{
    public static class Extensions
    {
        #region IocContainer

        /// <summary>
        /// Registers the default services for the IocContainer.
        /// If different plugin assemblies require different IocContainer setups, then utilize the IPluginServicesRegistrationRecorder and the PluginServicesRegistrationRecorder assembly attribute
        /// </summary>
        /// <param name="container"></param>
        /// <returns></returns>
        public static IIocContainer RegisterDefaultServices(this IIocContainer container)
        {
            // Register any custom services here
            container.AddSingleton(_ => new ExtendedOrganizationServiceSettings
            {
                // If you're using EarlyBound, this would be any type in the assembly that contains your early bound entities
                ProxyTypesAssembly = typeof(DataverseContext).Assembly
            });
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

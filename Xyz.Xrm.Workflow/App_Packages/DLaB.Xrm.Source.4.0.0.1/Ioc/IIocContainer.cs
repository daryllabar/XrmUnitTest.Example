﻿using System;

#if DLAB_UNROOT_NAMESPACE || DLAB_XRM
namespace DLaB.Xrm.Ioc
#else
namespace Source.DLaB.Xrm.Ioc
#endif
{

    /// <summary>
    /// Allows for registering all the services
    /// </summary>
    public interface IIocContainer
    {
        /// <summary>
        /// Registers the TService to have a scoped lifetime, meaning at most one single instance of the type will be created per each IServiceProvider built via BuildServiceProvider.
        /// </summary>
        IIocContainer AddScoped<TService>();
        /// <summary>
        /// Registers the TService to have a scoped lifetime, meaning at most one single instance of the type will be created per each IServiceProvider built via BuildServiceProvider.
        /// </summary>
        IIocContainer AddScoped<TService>(Func<IServiceProvider, TService> implementationFactory);
        /// <summary>
        /// Registers the TService to have a scoped lifetime, meaning at most one single instance of the type will be created per each IServiceProvider built via BuildServiceProvider.
        /// </summary>
        IIocContainer AddScoped<TService, TImplementation>() where TImplementation : TService;

        /// <summary>
        /// Registers the TService to have a Singleton lifetime, meaning at most one single instance of the type will be created per IIocContainer.
        /// </summary>
        IIocContainer AddSingleton<TService>();
        /// <summary>
        /// Registers the TService to have a Singleton lifetime, meaning at most one single instance of the type will be created per IIocContainer.
        /// </summary>
        IIocContainer AddSingleton<TService>(Func<IServiceProvider, TService> implementationFactory);
        /// <summary>
        /// Registers the TService to have a Singleton lifetime, meaning at most one single instance of the type will be created per IIocContainer.
        /// </summary>
        IIocContainer AddSingleton<TService>(TService implementationInstance);
        /// <summary>
        /// Registers the TService to have a Singleton lifetime, meaning at most one single instance of the type will be created per IIocContainer.
        /// </summary>
        IIocContainer AddSingleton<TService, TImplementation>() where TImplementation : TService;

        /// <summary>
        /// Registers the TService to have a Transient lifetime, meaning every time type is requested, a new instance will be created.
        /// </summary>
        IIocContainer AddTransient<TService>();
        /// <summary>
        /// Registers the TService to have a Transient lifetime, meaning every time type is requested, a new instance will be created.
        /// </summary>
        IIocContainer AddTransient<TService>(Func<IServiceProvider, TService> implementationFactory);
        /// <summary>
        /// Registers the TService to have a Transient lifetime, meaning every time type is requested, a new instance will be created.
        /// </summary>
        IIocContainer AddTransient<TService, TImplementation>() where TImplementation : TService;

        /// <summary>
        /// Creates a scoped IServiceProvider defaulting to the actualProvider if it is provided and the type is not explicitly registered.
        /// </summary>
        /// <param name="actualProvider"></param>
        /// <param name="defaultLifetime"></param>
        /// <returns></returns>
        IServiceProvider BuildServiceProvider(IServiceProvider actualProvider = null, Lifetime defaultLifetime = Lifetime.Scoped);
    }
}

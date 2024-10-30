﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0248;

using D8S.L0002.D002;

using OperatingSystem = D8S.L0002.T001.OperatingSystem;


namespace D8S.L0002.I002
{
    public static partial class IServiceCollectionExtensions
    {
        /// <inheritdoc cref="IServicesOperator.Add_ExecutingOperatingSystemProvider(IServiceCollection, out ServiceToken{IExecutingOperatingSystemProvider})"/>
        public static IServiceCollection Add_ExecutingOperatingSystemProvider(this IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            Instances.ServicesOperator.Add_ExecutingOperatingSystemProvider(
                services,
                out executingOperatingSystemProvider_Token);

            return services;
        }

        /// <inheritdoc cref="IServicesOperator.Add_ExecutingOperatingSystemProvider_Fixed(IServiceCollection, OperatingSystem, out ServiceToken{IExecutingOperatingSystemProvider})"/>
        public static IServiceCollection Add_ExecutingOperatingSystemProvider_Fixed(this IServiceCollection services,
            OperatingSystem operatingSystem,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            Instances.ServicesOperator.Add_ExecutingOperatingSystemProvider_Fixed(
                services,
                operatingSystem,
                out executingOperatingSystemProvider_Token);

            return services;
        }

        /// <inheritdoc cref="IServicesOperator.Add_ExecutingOperatingSystemProvider_Linux(IServiceCollection, out ServiceToken{IExecutingOperatingSystemProvider})"/>
        public static IServiceCollection Add_ExecutingOperatingSystemProvider_Linux(this IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            Instances.ServicesOperator.Add_ExecutingOperatingSystemProvider_Linux(
                services,
                out executingOperatingSystemProvider_Token);

            return services;
        }

        /// <inheritdoc cref="IServicesOperator.Add_ExecutingOperatingSystemProvider_Mac(IServiceCollection, out ServiceToken{IExecutingOperatingSystemProvider})"/>
        public static IServiceCollection Add_ExecutingOperatingSystemProvider_Mac(this IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            Instances.ServicesOperator.Add_ExecutingOperatingSystemProvider_Mac(
                services,
                out executingOperatingSystemProvider_Token);

            return services;
        }

        /// <inheritdoc cref="IServicesOperator.Add_ExecutingOperatingSystemProvider_Unknown(IServiceCollection, out ServiceToken{IExecutingOperatingSystemProvider})"/>
        public static IServiceCollection Add_ExecutingOperatingSystemProvider_Unknown(this IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            Instances.ServicesOperator.Add_ExecutingOperatingSystemProvider_Unknown(
                services,
                out executingOperatingSystemProvider_Token);

            return services;
        }

        /// <inheritdoc cref="IServicesOperator.Add_ExecutingOperatingSystemProvider_Windows(IServiceCollection, out ServiceToken{IExecutingOperatingSystemProvider})"/>
        public static IServiceCollection Add_ExecutingOperatingSystemProvider_Windows(this IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            Instances.ServicesOperator.Add_ExecutingOperatingSystemProvider_Windows(
                services,
                out executingOperatingSystemProvider_Token);

            return services;
        }
    }
}

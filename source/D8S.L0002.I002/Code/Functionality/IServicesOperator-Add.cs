using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0132;
using R5T.T0248;

using D8S.L0002.D002;

using OperatingSystem = D8S.L0002.T001.OperatingSystem;


namespace D8S.L0002.I002
{
    [FunctionalityMarker]
    public partial interface IServicesOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ExecutingOperatingSystemProvider"/>
        public void Add_ExecutingOperatingSystemProvider(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProviderd_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider>();
        }

        /// <inheritdoc cref="Add_ExecutingOperatingSystemProvider_Fixed"/>
        public void Add_ExecutingOperatingSystemProvider_Fixed(
            IServiceCollection services,
            OperatingSystem operatingSystem,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider_Fixed>(_ =>
            {
                return new ExecutingOperatingSystemProvider_Fixed(operatingSystem);
            });
        }

        /// <inheritdoc cref="ExecutingOperatingSystemProvider_Linux"/>
        public void Add_ExecutingOperatingSystemProvider_Linux(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider_Linux>();
        }

        /// <inheritdoc cref="ExecutingOperatingSystemProvider_Mac"/>
        public void Add_ExecutingOperatingSystemProvider_Mac(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider_Mac>();
        }

        /// <inheritdoc cref="ExecutingOperatingSystemProvider_Unknown"/>
        public void Add_ExecutingOperatingSystemProvider_Unknown(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider_Unknown>();
        }

        /// <inheritdoc cref="ExecutingOperatingSystemProvider_Windows"/>
        public void Add_ExecutingOperatingSystemProvider_Windows(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider_Windows>();
        }
    }
}

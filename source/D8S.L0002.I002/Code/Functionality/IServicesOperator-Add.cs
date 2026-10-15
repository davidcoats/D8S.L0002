using System;

using Microsoft.Extensions.DependencyInjection;

using F10Y.T0002;
using F10Y.T0016;

using D8S.L0002.D001;
using D8S.L0002.D002;

using OperatingSystem = D8S.L0002.T001.OperatingSystem;


namespace D8S.L0002.I002
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IServicesOperator
    {
        /// <inheritdoc cref="N001.TemporaryDirectoryPathProvider"/>
        void Add_TemporaryDirectoryPathProvider_N001(
            IServiceCollection services,
            out ServiceToken<ITemporaryDirectoryPathProvider> temporaryDirectoryPathProvider_Token,
            ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token,
            ServiceToken<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProvider_Token)
        {
            services.AddSingleton<ITemporaryDirectoryPathProvider, N001.TemporaryDirectoryPathProvider>();
        }

        /// <inheritdoc cref="ExecutingOperatingSystemProvider"/>
        void Add_ExecutingOperatingSystemProvider(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProviderd_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider>();
        }

        /// <inheritdoc cref="Add_ExecutingOperatingSystemProvider_Fixed"/>
        void Add_ExecutingOperatingSystemProvider_Fixed(
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
        void Add_ExecutingOperatingSystemProvider_Linux(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider_Linux>();
        }

        /// <inheritdoc cref="ExecutingOperatingSystemProvider_Mac"/>
        void Add_ExecutingOperatingSystemProvider_Mac(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider_Mac>();
        }

        /// <inheritdoc cref="ExecutingOperatingSystemProvider_Unknown"/>
        void Add_ExecutingOperatingSystemProvider_Unknown(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider_Unknown>();
        }

        /// <inheritdoc cref="ExecutingOperatingSystemProvider_Windows"/>
        void Add_ExecutingOperatingSystemProvider_Windows(
            IServiceCollection services,
            out ServiceToken<IExecutingOperatingSystemProvider> executingOperatingSystemProvider_Token)
        {
            services.AddSingleton<IExecutingOperatingSystemProvider, ExecutingOperatingSystemProvider_Windows>();
        }
    }
}

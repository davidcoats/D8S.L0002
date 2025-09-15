using System;

using Microsoft.Extensions.DependencyInjection;

using F10Y.T0002;
using F10Y.T0016;

using D8S.L0002.D001;


namespace D8S.L0002.I001
{
    [FunctionsMarker]
    public partial interface IServicesOperator
    {
        /// <inheritdoc cref="N001.TemporaryDirectoryPathProvider"/>
        public void Add_TemporaryDirectoryPathProvider_N001(
            IServiceCollection services,
            out ServiceToken<ITemporaryDirectoryPathProvider> temporaryDirectoryPathProvider_Token)
        {
            services.AddSingleton<ITemporaryDirectoryPathProvider, N001.TemporaryDirectoryPathProvider>();
        }

        /// <inheritdoc cref="DropboxDirectoryPathProvider"/>
        public void Add_DropboxDirectoryPathProvider(
            IServiceCollection services,
            out ServiceToken<IDropboxDirectoryPathProvider> dropboxDirectoryPathProvider_Token,
            ServiceToken<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProvider_Token)
        {
            services.AddSingleton<IDropboxDirectoryPathProvider, DropboxDirectoryPathProvider>();
        }

        /// <inheritdoc cref="UserProfileDirectoryPathProvider"/>
        public void Add_UserProfileDirectoryPathProvider(
            IServiceCollection services,
            out ServiceToken<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProvider_Token)
        {
            services.AddSingleton<IUserProfileDirectoryPathProvider, UserProfileDirectoryPathProvider>();
        }
    }
}

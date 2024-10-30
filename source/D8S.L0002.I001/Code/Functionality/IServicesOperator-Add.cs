using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0132;
using R5T.T0248;

using D8S.L0002.D001;


namespace D8S.L0002.I001
{
    [FunctionalityMarker]
    public partial interface IServicesOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="DropboxDirectoryPathProvider"/>
        public void Add_DropboxDirectoryPathProvider(
            IServiceCollection services,
            out ServiceToken<IDropboxDirectoryPathProvider> ropboxDirectoryPathProvider_Token,
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

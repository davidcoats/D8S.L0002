using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0248;

using D8S.L0002.D001;


namespace D8S.L0002.I001
{
    public static partial class IServiceCollectionExtensions
    {
        /// <inheritdoc cref="IServicesOperator.Add_DropboxDirectoryPathProvider(IServiceCollection, out ServiceToken{IDropboxDirectoryPathProvider}, ServiceToken{IUserProfileDirectoryPathProvider})"/>
        public static IServiceCollection Add_DropboxDirectoryPathProvider(this IServiceCollection services,
            out ServiceToken<IDropboxDirectoryPathProvider> dropboxDirectoryPathProvider_Token,
            ServiceToken<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProvider_Token)
        {
            Instances.ServicesOperator.Add_DropboxDirectoryPathProvider(
                services,
                out dropboxDirectoryPathProvider_Token,
                userProfileDirectoryPathProvider_Token);

            return services;
        }

        /// <inheritdoc cref="IServicesOperator.Add_UserProfileDirectoryPathProvider(IServiceCollection, out ServiceToken{IUserProfileDirectoryPathProvider})"/>
        public static IServiceCollection Add_UserProfileDirectoryPathProvider(this IServiceCollection services,
            out ServiceToken<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProvider_Token)
        {
            Instances.ServicesOperator.Add_UserProfileDirectoryPathProvider(
                services,
                out userProfileDirectoryPathProvider_Token);

            return services;
        }
    }
}

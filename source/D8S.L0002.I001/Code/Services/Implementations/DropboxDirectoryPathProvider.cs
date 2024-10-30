using System;
using System.Threading.Tasks;

using R5T.T0064;

using D8S.L0002.D001;


namespace D8S.L0002.I001
{
    /// <summary>
    /// Implementation of <see cref="IDropboxDirectoryPathProvider"/> that uses the <see cref="IUserProfileDirectoryPathProvider"/> service.
    /// </summary>
    [ServiceImplementationMarker]
    public class DropboxDirectoryPathProvider : IDropboxDirectoryPathProvider, IServiceImplementation
    {
        private IUserProfileDirectoryPathProvider UserProfileDirectoryPathProvider { get; }


        public DropboxDirectoryPathProvider(
            IUserProfileDirectoryPathProvider userProfileDirectoryPathProvider)
        {
            this.UserProfileDirectoryPathProvider = userProfileDirectoryPathProvider;
        }

        public async Task<string> Get_DropboxDirectoryPath()
        {
            var userProfileDirectoryPath = await this.UserProfileDirectoryPathProvider.Get_UserProfileDirectoryPath();

            var output = Instances.PathOperator.Get_DirectoryPath(
                userProfileDirectoryPath,
                Instances.DirectoryNames.Dropbox);

            return output;
        }
    }
}
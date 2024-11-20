using System;
using System.Threading.Tasks;

using R5T.T0064;

using D8S.L0002.D001;
using D8S.L0002.D002;
using D8S.L0002.D002.X001;


namespace D8S.L0002.I002.N001
{
    /// <summary>
    /// Provides an operating system dependent temporary directory path.
    /// </summary>
    /// <remarks>
    /// Works on both Windows and MacOS.
    /// </remarks>
    [ServiceImplementationMarker]
    public class TemporaryDirectoryPathProvider : IServiceImplementation,
        ITemporaryDirectoryPathProvider
    {
        public IExecutingOperatingSystemProvider ExecutingOperatingSystemProvider { get; }
        public IUserProfileDirectoryPathProvider UserProfileDirectoryPathProvider { get; }


        public TemporaryDirectoryPathProvider(
            IExecutingOperatingSystemProvider executingOperatingSystemProvider,
            IUserProfileDirectoryPathProvider userProfileDirectoryPathProvider)
        {
            this.ExecutingOperatingSystemProvider = executingOperatingSystemProvider;
            this.UserProfileDirectoryPathProvider = userProfileDirectoryPathProvider;
        }

        public async Task<string> Get_TemporaryDirectoryPath()
        {
            var output_ProviderAction = await this.ExecutingOperatingSystemProvider.Switch_OnExecutingOperatingSystem<Func<Task<string>>>(
                () =>
                {
                    // On Windows, return the hard-coded value.
                    var output = Instances.DirectoryPaths.C_Temp;
                    return Task.FromResult(output);
                },
                async () =>
                {
                    // On MacOS, use a directory in the user's profile directory.
                    var userProfileDirectoryPath = await this.UserProfileDirectoryPathProvider.Get_UserProfileDirectoryPath();

                    var output = Instances.PathOperator.Get_DirectoryPath(
                        userProfileDirectoryPath,
                        Instances.DirectoryNames.Temp);

                    return output;
                });

            var output = await output_ProviderAction();
            return output;
        }
    }
}
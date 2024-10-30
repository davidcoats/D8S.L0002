using System;
using System.Threading.Tasks;

using R5T.T0064;

using D8S.L0002.D001;


namespace D8S.L0002.I001
{
    /// <summary>
    /// An implementation of <see cref="IUserProfileDirectoryPathProvider"/> that gets the path of the profile directory for the current user on the current system.
    /// <para>For example, this is <inheritdoc cref="R5T.Y0006.Documentation.For_Directories.UserProfile_OnWindows" path="/summary"/>.</para>
    /// </summary>
    [ServiceImplementationMarker]
    public class UserProfileDirectoryPathProvider : IUserProfileDirectoryPathProvider, IServiceImplementation
    {
        public Task<string> Get_UserProfileDirectoryPath()
        {
            var output = Instances.EnvironmentOperator.Get_UserProfileDirectoryPath();

            return Task.FromResult(output);
        }
    }
}
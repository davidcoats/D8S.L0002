using System;
using System.Threading.Tasks;

using F10Y.T0015;


namespace D8S.L0002.D001
{
    /// <summary>
    /// Gets user profile directory path.
    /// </summary>
    /// <remarks>
    /// Left up to implementers is whethere this is the current user, or on the current system.
    /// </remarks>
    [ServiceDefinitionMarker]
    public interface IUserProfileDirectoryPathProvider
    {
        Task<string> Get_UserProfileDirectoryPath();
    }
}
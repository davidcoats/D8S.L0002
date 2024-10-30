using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace D8S.L0002.D001
{
    /// <summary>
    /// Provides the path of the Dropbox directory.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IDropboxDirectoryPathProvider : IServiceDefinition
    {
        Task<string> Get_DropboxDirectoryPath();
    }
}
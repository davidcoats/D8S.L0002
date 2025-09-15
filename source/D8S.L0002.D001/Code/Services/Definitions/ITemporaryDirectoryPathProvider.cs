using System;
using System.Threading.Tasks;

using F10Y.T0015;


namespace D8S.L0002.D001
{
    /// <summary>
    /// Provides the path of the temporary directory.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ITemporaryDirectoryPathProvider
    {
        Task<string> Get_TemporaryDirectoryPath();
    }
}
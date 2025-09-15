using System;
using System.Threading.Tasks;

using F10Y.T0015;

using D8S.L0002.D001;


namespace D8S.L0002.I001.N001
{
    /// <summary>
    /// Uses the hard-coded value "<inheritdoc cref="Z001.IDirectoryPaths.C_Temp" path="descendant::value"/>" (from <see cref="Z001.IDirectoryPaths.C_Temp"/>).
    /// </summary>
    /// <remarks>
    /// Only works on Windows machines.
    /// </remarks>
    [ServiceImplementationMarker]
    public class TemporaryDirectoryPathProvider :
        ITemporaryDirectoryPathProvider
    {
        public Task<string> Get_TemporaryDirectoryPath()
        {
            var output = Instances.DirectoryPaths.C_Temp;

            return Task.FromResult(output);
        }
    }
}
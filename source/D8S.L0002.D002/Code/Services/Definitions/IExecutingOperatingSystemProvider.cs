using System;
using System.Threading.Tasks;

using F10Y.T0015;

using OperatingSystem = D8S.L0002.T001.OperatingSystem;


namespace D8S.L0002.D002
{
    /// <summary>
    /// Get the executing operating system as a <see cref="OperatingSystem"/> enumeration value.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IExecutingOperatingSystemProvider
    {
        Task<OperatingSystem> Get_ExecutingOperatingSystem();
    }
}
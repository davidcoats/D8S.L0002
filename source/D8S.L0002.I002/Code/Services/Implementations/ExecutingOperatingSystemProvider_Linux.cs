using System;
using System.Threading.Tasks;

using R5T.T0064;

using D8S.L0002.D002;

using OperatingSystem = D8S.L0002.T001.OperatingSystem;


namespace D8S.L0002.I002
{
    /// <summary>
    /// An <see cref="IExecutingOperatingSystemProvider"/> implementation that is hard-coded to produce the <see cref="OperatingSystem.Linux"/> value.
    /// </summary>
    [ServiceImplementationMarker]
    public class ExecutingOperatingSystemProvider_Linux : IServiceImplementation,
        IExecutingOperatingSystemProvider
    {
        public Task<OperatingSystem> Get_ExecutingOperatingSystem()
        {
            var output = OperatingSystem.Linux;

            return Task.FromResult(output);
        }
    }
}
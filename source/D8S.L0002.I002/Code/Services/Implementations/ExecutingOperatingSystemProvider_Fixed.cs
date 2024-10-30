using System;
using System.Threading.Tasks;

using R5T.T0064;

using D8S.L0002.D002;

using OperatingSystem = D8S.L0002.T001.OperatingSystem;


namespace D8S.L0002.I002
{
    /// <summary>
    /// An <see cref="IExecutingOperatingSystemProvider"/> implementation that provides a (configurable) fixed value.
    /// </summary>
    [ServiceImplementationMarker]
    public class ExecutingOperatingSystemProvider_Fixed : IServiceImplementation,
        IExecutingOperatingSystemProvider
    {
        public OperatingSystem OperatingSystem { get; }


        public ExecutingOperatingSystemProvider_Fixed(OperatingSystem operatingSystem)
        {
            this.OperatingSystem = operatingSystem;
        }

        public Task<OperatingSystem> Get_ExecutingOperatingSystem()
        {
            return Task.FromResult(this.OperatingSystem);
        }
    }
}
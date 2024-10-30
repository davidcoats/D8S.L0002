using System;
using System.Threading.Tasks;

using R5T.T0064;

using D8S.L0002.D002;

using OperatingSystem = D8S.L0002.T001.OperatingSystem;


namespace D8S.L0002.I002
{
    /// <summary>
    /// A default <see cref="IExecutingOperatingSystemProvider"/> implementation.
    /// </summary>
    /// <remarks>
    /// Uses <see cref="L002.IOperatingSystemOperator.Get_OperatingSystem_Executing"/>.
    /// </remarks>
    [ServiceImplementationMarker]
    public class ExecutingOperatingSystemProvider : IServiceImplementation,
        IExecutingOperatingSystemProvider
    {
        public Task<OperatingSystem> Get_ExecutingOperatingSystem()
        {
            var output = Instances.OperatingSystemOperator.Get_OperatingSystem_Executing();

            return Task.FromResult(output);
        }
    }
}
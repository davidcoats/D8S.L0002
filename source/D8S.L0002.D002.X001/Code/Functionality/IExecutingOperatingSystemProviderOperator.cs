using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace D8S.L0002.D002.X001
{
    [FunctionalityMarker]
    public partial interface IExecutingOperatingSystemProviderOperator : IFunctionalityMarker
    {
        public async Task<T> Switch_OnExecutingOperatingSystem<T>(IExecutingOperatingSystemProvider executingOperatingSystemProvider,
            T windowsValue,
            T osxValue,
            T linuxValue,
            T unknownValue)
        {
            var operatingSystem = await executingOperatingSystemProvider.Get_ExecutingOperatingSystem();

            var output = Instances.OperatingSystemOperator.SwitchOn_OperatingSystem_ByValue(
                operatingSystem,
                windowsValue,
                osxValue,
                linuxValue,
                unknownValue);

            return output;
        }

        public async Task<T> Switch_OnExecutingOperatingSystem<T>(IExecutingOperatingSystemProvider executingOperatingSystemProvider,
            T windowsValue,
            T osxValue,
            T linuxValue)
        {
            var operatingSystem = await executingOperatingSystemProvider.Get_ExecutingOperatingSystem();

            var output = Instances.OperatingSystemOperator.SwitchOn_OperatingSystem_ByValue(
                operatingSystem,
                windowsValue,
                osxValue,
                linuxValue);

            return output;
        }

        public async Task<T> Switch_OnExecutingOperatingSystem<T>(IExecutingOperatingSystemProvider executingOperatingSystemProvider,
            T windowsValue,
            T osxValue)
        {
            var operatingSystem = await executingOperatingSystemProvider.Get_ExecutingOperatingSystem();

            var output = Instances.OperatingSystemOperator.SwitchOn_OperatingSystem_ByValue(
                operatingSystem,
                windowsValue,
                osxValue);

            return output;
        }
    }
}

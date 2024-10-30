using System;
using System.Threading.Tasks;


namespace D8S.L0002.D002.X001
{
    public static class IExecutingOperatingSystemProviderExtensions
    {
        public static Task<T> Switch_OnExecutingOperatingSystem<T>(this IExecutingOperatingSystemProvider executingOperatingSystemProvider,
            T windowsValue,
            T osxValue,
            T linuxValue,
            T unknownValue)
            => Instances.ExecutingOperatingSystemProviderOperator.Switch_OnExecutingOperatingSystem(
                executingOperatingSystemProvider,
                windowsValue,
                osxValue,
                linuxValue,
                unknownValue);

        public static Task<T> Switch_OnExecutingOperatingSystem<T>(this IExecutingOperatingSystemProvider executingOperatingSystemProvider,
            T windowsValue,
            T osxValue,
            T linuxValue)
            => Instances.ExecutingOperatingSystemProviderOperator.Switch_OnExecutingOperatingSystem(
                executingOperatingSystemProvider,
                windowsValue,
                osxValue,
                linuxValue);

        public static Task<T> Switch_OnExecutingOperatingSystem<T>(this IExecutingOperatingSystemProvider executingOperatingSystemProvider,
            T windowsValue,
            T osxValue)
            => Instances.ExecutingOperatingSystemProviderOperator.Switch_OnExecutingOperatingSystem(
                executingOperatingSystemProvider,
                windowsValue,
                osxValue);
    }
}

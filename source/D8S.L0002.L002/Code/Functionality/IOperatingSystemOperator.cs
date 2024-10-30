using System;
using R5T.T0132;

using OperatingSystem = D8S.L0002.T001.OperatingSystem;


namespace D8S.L0002.L002
{
    [FunctionalityMarker]
    public partial interface IOperatingSystemOperator : IFunctionalityMarker,
        R5T.L0066.IOperatingSystemOperator
    {
        /// <summary>
        /// Get an enumeration value describing the executing operating system.
        /// </summary>
        public OperatingSystem Get_OperatingSystem_Executing()
        {
            var output = this.SwitchOn_OSPlatform_ByValue(
                OperatingSystem.Windows,
                OperatingSystem.Mac,
                OperatingSystem.Linux,
                OperatingSystem.Unknown);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="Get_OperatingSystem_Executing"/> as the default.
        /// </summary>
        public OperatingSystem Get_OperatingSystem()
            => this.Get_OperatingSystem_Executing();

        /// <summary>
        /// Gets the moniker of the currently executing operating system.
        /// </summary>
        public string Get_OperatingSystemMoniker_Executing()
        {
            var operatingSystem_Executing = this.Get_OperatingSystem_Executing();

            var output = this.Get_OperatingSystemMoniker(operatingSystem_Executing);
            return output;
        }

        /// <summary>
        /// Chooses <see cref="Get_OperatingSystemMoniker_Executing"/> as the default.
        /// </summary>
        public string Get_OperatingSystemMoniker()
            => this.Get_OperatingSystemMoniker_Executing();

        public string Get_OperatingSystemMoniker(OperatingSystem operatingSystem)
        {
            var output = operatingSystem switch
            {
                OperatingSystem.Linux => Instances.OperatingSystemMonikers.Linux,
                OperatingSystem.Mac => Instances.OperatingSystemMonikers.Mac,
                OperatingSystem.Unknown => Instances.OperatingSystemMonikers.UNKNOWN,
                OperatingSystem.Windows => Instances.OperatingSystemMonikers.Windows,
                _ => throw Instances.SwitchOperator.Get_DefaultCaseException(operatingSystem)
            };

            return output;
        }

        public T SwitchOn_OperatingSystem_ByValue<T>(
            OperatingSystem operatingSystem,
            T windowsValue,
            T osxValue,
            T linuxValue,
            T unknownValue)
            => operatingSystem switch
            {
                OperatingSystem.Linux => linuxValue,
                OperatingSystem.Mac => osxValue,
                OperatingSystem.Unknown => unknownValue,
                OperatingSystem.Windows => windowsValue,
                _ => throw Instances.SwitchOperator.Get_DefaultCaseException(operatingSystem)
            };

        public T SwitchOn_OperatingSystem_ByValue<T>(
            OperatingSystem operatingSystem,
            T windowsValue,
            T osxValue,
            T linuxValue)
            => operatingSystem switch
            {
                OperatingSystem.Linux => linuxValue,
                OperatingSystem.Mac => osxValue,
                OperatingSystem.Windows => windowsValue,
                _ => throw Instances.SwitchOperator.Get_DefaultCaseException(operatingSystem)
            };

        public T SwitchOn_OperatingSystem_ByValue<T>(
           OperatingSystem operatingSystem,
           T windowsValue,
           T osxValue)
           => operatingSystem switch
           {
               OperatingSystem.Mac => osxValue,
               OperatingSystem.Windows => windowsValue,
               _ => throw Instances.SwitchOperator.Get_DefaultCaseException(operatingSystem)
           };
    }
}

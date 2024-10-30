using System;


namespace D8S.L0002.Z001
{
    public class OperatingSystemMonikers : IOperatingSystemMonikers
    {
        #region Infrastructure

        public static IOperatingSystemMonikers Instance { get; } = new OperatingSystemMonikers();


        private OperatingSystemMonikers()
        {
        }

        #endregion
    }
}

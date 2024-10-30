using System;


namespace D8S.L0002.D002.X001
{
    public static class Instances
    {
        public static IExecutingOperatingSystemProviderOperator ExecutingOperatingSystemProviderOperator => X001.ExecutingOperatingSystemProviderOperator.Instance;
        public static L002.IOperatingSystemOperator OperatingSystemOperator => L002.OperatingSystemOperator.Instance;
    }
}
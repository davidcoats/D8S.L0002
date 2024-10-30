using System;


namespace D8S.L0002.I002
{
    public static class Instances
    {
        public static L002.IOperatingSystemOperator OperatingSystemOperator => L002.OperatingSystemOperator.Instance;
        public static IServicesOperator ServicesOperator => I002.ServicesOperator.Instance;
    }
}
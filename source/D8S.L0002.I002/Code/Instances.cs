using System;


namespace D8S.L0002.I002
{
    public static class Instances
    {
        public static Z001.IDirectoryNames DirectoryNames => Z001.DirectoryNames.Instance;
        public static Z001.IDirectoryPaths DirectoryPaths => Z001.DirectoryPaths.Instance;
        public static L002.IOperatingSystemOperator OperatingSystemOperator => L002.OperatingSystemOperator.Instance;
        public static F10Y.L0000.IPathOperator PathOperator => F10Y.L0000.PathOperator.Instance;
        public static IServicesOperator ServicesOperator => I002.ServicesOperator.Instance;
    }
}
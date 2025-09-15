using System;


namespace D8S.L0002.I001
{
    public static class Instances
    {
        public static Z001.IDirectoryNames DirectoryNames => Z001.DirectoryNames.Instance;
        public static Z001.IDirectoryPaths DirectoryPaths => Z001.DirectoryPaths.Instance;
        public static F10Y.L0000.IEnvironmentOperator EnvironmentOperator => F10Y.L0000.EnvironmentOperator.Instance;
        public static F10Y.L0000.IPathOperator PathOperator => F10Y.L0000.PathOperator.Instance;
        public static IServicesOperator ServicesOperator => I001.ServicesOperator.Instance;
    }
}
using System;


namespace D8S.L0002.I001
{
    public static class Instances
    {
        public static Z001.IDirectoryNames DirectoryNames => Z001.DirectoryNames.Instance;
        public static Z001.IDirectoryPaths DirectoryPaths => Z001.DirectoryPaths.Instance;
        public static R5T.L0066.IEnvironmentOperator EnvironmentOperator => R5T.L0066.EnvironmentOperator.Instance;
        public static R5T.L0066.IPathOperator PathOperator => R5T.L0066.PathOperator.Instance;
        public static IServicesOperator ServicesOperator => I001.ServicesOperator.Instance;
    }
}
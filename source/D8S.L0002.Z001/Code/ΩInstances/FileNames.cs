using System;


namespace D8S.L0002.Z001
{
    public class FileNames : IFileNames
    {
        #region Infrastructure

        public static IFileNames Instance { get; } = new FileNames();


        private FileNames()
        {
        }

        #endregion
    }
}

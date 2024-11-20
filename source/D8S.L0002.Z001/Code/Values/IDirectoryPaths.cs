using System;

using R5T.T0131;


namespace D8S.L0002.Z001
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        /// <summary>
        /// <para><value>C:\Temp\</value></para>
        /// </summary>
        public string C_Temp => @"C:\Temp\";
    }
}

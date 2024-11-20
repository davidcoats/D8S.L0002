using System;

using R5T.T0131;


namespace D8S.L0002.Z001
{
    [ValuesMarker]
    public partial interface IDirectoryNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>Dropbox</value></para>
        /// </summary>
        public string Dropbox => "Dropbox";

        /// <summary>
        /// <para><value>Temp</value></para>
        /// </summary>
        public string Temp => "Temp";
    }
}

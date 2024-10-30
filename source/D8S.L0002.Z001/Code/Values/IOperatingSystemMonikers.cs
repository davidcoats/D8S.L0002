using System;

using R5T.T0131;


namespace D8S.L0002.Z001
{
    [ValuesMarker]
    public partial interface IOperatingSystemMonikers : IValuesMarker
    {
        /// <summary>
        /// <para><value>Linux</value></para>
        /// </summary>
        public string Linux => "Linux";

        /// <summary>
        /// <para><value>Mac</value></para>
        /// </summary>
        public string Mac => "Mac";

        /// <summary>
        /// <para><value>UNKNOWN</value></para>
        /// </summary>
        public string UNKNOWN => "UNKNOWN";

        /// <summary>
        /// <para><value>Windows</value></para>
        /// </summary>
        public string Windows => "Windows";
    }
}

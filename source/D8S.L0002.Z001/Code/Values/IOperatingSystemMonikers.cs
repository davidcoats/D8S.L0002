using System;

using F10Y.T0003;


namespace D8S.L0002.Z001
{
    [ValuesMarker]
    public partial interface IOperatingSystemMonikers
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

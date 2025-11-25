using System;

using F10Y.T0003;


namespace D8S.L0002.Z001
{
    [ValuesMarker]
    public partial interface IFileNames
    {
        /// <summary>
        /// <para><value>Output.txt</value></para>
        /// </summary>
        public string Output_txt => "Output.txt";

        /// <summary>
        /// <para><value>Assembly Paths.txt</value></para>
        /// </summary>
        string AssemblyPaths_txt => "Assembly Paths.txt";
    }
}

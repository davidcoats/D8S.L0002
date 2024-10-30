using System;
using System.Diagnostics;

using R5T.T0131;


namespace D8S.L0002.L001.Raw
{
    [ValuesMarker]
    public partial interface IProcessStartInfos : IValuesMarker
    {
        /// <summary>
        /// A good window-less process start information.
        /// <para>
        /// <list type="bullet">
        /// <item><see cref="ProcessStartInfo.UseShellExecute"/>: false</item>
        /// <item><see cref="ProcessStartInfo.CreateNoWindow"/>: true</item>
        /// <item><see cref="ProcessStartInfo.RedirectStandardError"/>: true</item>
        /// <item><see cref="ProcessStartInfo.RedirectStandardOutput"/>: true</item>
        /// </list>
        /// </para>
        /// </summary>
        public ProcessStartInfo N_001 => new ProcessStartInfo()
        {
            UseShellExecute = false,
            CreateNoWindow = true,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
        };
    }
}

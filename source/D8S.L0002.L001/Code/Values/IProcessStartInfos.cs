using System;
using System.Diagnostics;

using R5T.T0131;
using R5T.T0143;


namespace D8S.L0002.L001
{
    [ValuesMarker]
    public partial interface IProcessStartInfos : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IProcessStartInfos _Raw => Raw.ProcessStartInfos.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <inheritdoc cref="Raw.IProcessStartInfos.N_001"/>
        public ProcessStartInfo Windowless => _Raw.N_001;
    }
}

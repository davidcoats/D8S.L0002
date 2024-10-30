using System;


namespace D8S.L0002.L001
{
    public class ProcessStartInfos : IProcessStartInfos
    {
        #region Infrastructure

        public static IProcessStartInfos Instance { get; } = new ProcessStartInfos();


        private ProcessStartInfos()
        {
        }

        #endregion
    }
}


namespace D8S.L0002.L001.Raw
{
    public class ProcessStartInfos : IProcessStartInfos
    {
        #region Infrastructure

        public static IProcessStartInfos Instance { get; } = new ProcessStartInfos();


        private ProcessStartInfos()
        {
        }

        #endregion
    }
}
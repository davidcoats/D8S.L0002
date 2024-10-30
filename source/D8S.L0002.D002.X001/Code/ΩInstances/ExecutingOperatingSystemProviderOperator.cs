using System;


namespace D8S.L0002.D002.X001
{
    public class ExecutingOperatingSystemProviderOperator : IExecutingOperatingSystemProviderOperator
    {
        #region Infrastructure

        public static IExecutingOperatingSystemProviderOperator Instance { get; } = new ExecutingOperatingSystemProviderOperator();


        private ExecutingOperatingSystemProviderOperator()
        {
        }

        #endregion
    }
}

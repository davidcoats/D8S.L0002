using System;


namespace D8S.L0002.L002
{
    public class OperatingSystemOperator : IOperatingSystemOperator
    {
        #region Infrastructure

        public static IOperatingSystemOperator Instance { get; } = new OperatingSystemOperator();


        private OperatingSystemOperator()
        {
        }

        #endregion
    }
}

using System;


namespace D8S.L0002.L001
{
    public class ProcessOperator : IProcessOperator
    {
        #region Infrastructure

        public static IProcessOperator Instance { get; } = new ProcessOperator();


        private ProcessOperator()
        {
        }

        #endregion
    }
}

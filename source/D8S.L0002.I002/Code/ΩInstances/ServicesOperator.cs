using System;


namespace D8S.L0002.I002
{
    public class ServicesOperator : IServicesOperator
    {
        #region Infrastructure

        public static IServicesOperator Instance { get; } = new ServicesOperator();


        private ServicesOperator()
        {
        }

        #endregion
    }
}

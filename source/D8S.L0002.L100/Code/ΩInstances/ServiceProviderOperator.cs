using System;


namespace D8S.L0002.L100
{
    public class ServiceProviderOperator : IServiceProviderOperator
    {
        #region Infrastructure

        public static IServiceProviderOperator Instance { get; } = new ServiceProviderOperator();


        private ServiceProviderOperator()
        {
        }

        #endregion
    }
}

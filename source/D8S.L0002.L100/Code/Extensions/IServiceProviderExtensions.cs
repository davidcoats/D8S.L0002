using System;

using R5T.T0248;


namespace D8S.L0002.L100.Extensions
{
    public static partial class IServiceProviderExtensions
    {
        public static TService Get_Service<TService>(this IServiceProvider serviceProvider,
            // Dummy token to specify service type.
            ServiceToken<TService> serviceToken)
            => Instances.ServiceProviderOperator.Get_Service(
                serviceProvider,
                serviceToken);
    }
}

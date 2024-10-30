using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0132;
using R5T.T0248;


namespace D8S.L0002.L100
{
    [FunctionalityMarker]
    public partial interface IServiceProviderOperator : IFunctionalityMarker
    {
        public TService Get_Service<TService>(
            IServiceProvider serviceProvider,
            // Dummy token to specify service type.
            ServiceToken<TService> serviceToken)
        {
            var output = serviceProvider.GetRequiredService<TService>();
            return output;
        }
    }
}

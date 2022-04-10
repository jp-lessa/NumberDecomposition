using Microsoft.Extensions.DependencyInjection;
using NumberDecomposition.Domain.Core.Interfaces;
using NumberDecomposition.Domain.Services.Services;
using System;

namespace NumberDecomposition.Infrastructure.IOC
{
    public class NativeInjection
    {

        public static ServiceProvider GetProvider(IServiceCollection services)
        {
            RegistrarServices(services);
            return services.BuildServiceProvider();
        }

        public static void RegistrarServices(IServiceCollection services)
        {
            services.AddTransient<INumberDecompositionService, NumberDecompositionService>();
        }
    }
}

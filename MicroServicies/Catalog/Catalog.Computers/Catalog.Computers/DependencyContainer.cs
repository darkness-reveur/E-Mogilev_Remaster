using Catalog.Computers.Infrastructure.Services.ComputerComponents.Implementations;
using Catalog.Computers.Infrastructure.Services.ComputerComponents.Interfacies;

namespace Catalog.Computers
{
    public static class DependencyContainer
    {
        public static void RegisterDependesy(this IServiceCollection service)
        {
            service.AddTransient<IRAMService, RAMService>();
        }
    }
}

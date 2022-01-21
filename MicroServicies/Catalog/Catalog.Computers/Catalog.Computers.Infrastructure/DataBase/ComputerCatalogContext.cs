using Microsoft.EntityFrameworkCore;
using Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.RAM;
using Catalog.Computers.Cummon.ImputModelsDatas.ComputerAccessories;
using Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents;
using Catalog.Computers.Cummon.ImputModelsDatas;
using Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.CPU;
using Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.CPU.HelperTypes;
using Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.RAM.HelperTypes;

namespace Catalog.Computers.Infrastructure.DataBase
{
    public class ComputerCatalogContext : DbContext
    {
        public ComputerCatalogContext(DbContextOptions<ComputerCatalogContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ComputerComponentsCategory> ComputerComponentsCategories { get; set; }

        public DbSet<CPU> CPUs { get; set; }

        public DbSet<CPUBrand> CPUBrands { get; set; }

        public DbSet<CPUIntegratedPCIExpressController> CPUIntegratedPCIExpressControllers { get; set; }

        public DbSet<CPUModel> CPUModels { get; set; }

        public DbSet<CPUSocket> CPUSockets { get; set; }

        public DbSet<RAM> RAMs { get; set; }

        public DbSet<RAMBrand> RAMBrands { get; set; }

        public DbSet<RAMModel> RAMModels { get; set; }

        public DbSet<RAMType> RAMTypes { get; set; }

        public DbSet<ComputerAccessoriesCategory> ComputerAccessoriesCategories { get; set; }

    }
}

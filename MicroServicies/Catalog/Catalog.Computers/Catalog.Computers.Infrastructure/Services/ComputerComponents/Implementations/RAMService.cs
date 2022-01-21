using Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.RAM;
using Catalog.Computers.Infrastructure.DataBase;
using Catalog.Computers.Infrastructure.Services.ComputerComponents.Interfacies;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Computers.Infrastructure.Services.ComputerComponents.Implementations
{
    public class RAMService : IRAMService
    {
        private readonly ComputerCatalogContext _computerCatalogContext;

        public RAMService(ComputerCatalogContext computerCatalogContext)
        {
            _computerCatalogContext = computerCatalogContext;
        }

        public async Task<RAM> AddRAMAsync(RAM newRAM)
        {
            RAM rAM = new RAM
            {
                Name = "ОперативОчка",
                Price = 830,
                ReleaseDate = 2018,
                Description = "Самая пиздатая оперативОЧКА",
                Memory = 8,
                Backlight = true,
                XMPProfile = true,
                AMPProfile = true,
                Cooling = true,
                LowProfileLevel = false,
                ErrorCorrectionCoding = true,
                Frequency = 3200,
                RAMCount = 2,
                RAMSupplyVoltage = 1.35
            };

            await _computerCatalogContext.RAMs
                .AddAsync(newRAM);

            await _computerCatalogContext.SaveChangesAsync();

            return newRAM;

        }

        public async Task<IEnumerable<RAM>> GetAllRAMsAsync()
        {
            var RAMs = await _computerCatalogContext.RAMs
                .Include(RAM => RAM.RAMModel)
                .ThenInclude(model => model.RAMBrand)
                .Include(RAM => RAM.RAMType)
                .ToListAsync();

            return RAMs;
        }

        public Task<RAM> GetRAMByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<RAM> UpdateCarAsync(RAM newRAM)
        {
            throw new NotImplementedException();
        }
    }
}

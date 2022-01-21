using Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.RAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Computers.Infrastructure.Services.ComputerComponents.Interfacies
{
    public  interface IRAMService
    {
        Task<IEnumerable<RAM>> GetAllRAMsAsync();

        Task<RAM> GetRAMByIdAsync(int Id);

        Task<RAM> AddRAMAsync(RAM newRAM);

        Task<RAM> UpdateCarAsync(RAM newRAM);
    }
}

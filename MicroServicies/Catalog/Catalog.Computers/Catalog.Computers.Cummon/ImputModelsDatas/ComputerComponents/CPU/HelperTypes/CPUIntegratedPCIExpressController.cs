using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.CPU.HelperTypes
{
    public class CPUIntegratedPCIExpressController
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

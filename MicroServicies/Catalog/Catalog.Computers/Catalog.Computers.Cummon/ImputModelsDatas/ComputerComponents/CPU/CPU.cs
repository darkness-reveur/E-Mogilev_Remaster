using Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.CPU.HelperTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.CPU
{
    public class CPU
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool CoolingIncluded { get; set; }

        [Required]
        public int CoresCount { get; set; }

        [Required]
        public int BaseClockFrequency { get; set; }

        [Required]
        public int MaxClockFrequency { get; set; }

        [Required]
        public int TeoreticalThermalPower { get; set; }

        [Required]
        public int SocketId { get; set; }

        [ForeignKey("SocketId")]
        public CPUSocket Socket { get; set; }

        [Required]
        public int ModelId { get; set; }

        [ForeignKey("ModelId")]
        public CPUModel Model { get; set; }

        [Required]
        public int BrandId { get; set; }

        [ForeignKey("BrandId")]
        public CPUBrand Brand { get; set; }

        [Required]
        public int IntegratedPCIExpressControllerId { get; set; }

        [ForeignKey("IntegratedPCIExpressControllerId")]
        public CPUIntegratedPCIExpressController IntegratedPCIExpressController { get; set; }
    }
}

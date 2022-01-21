using Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.RAM.HelperTypes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.RAM
{
    public class RAM
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int ReleaseDate { get; set; }

        [Required]
        public string Description { get; set; }       //Need to do Short Description

        [Required]
        public int Memory { get; set; }

        [Required]
        public bool Backlight { get; set; } 

        [Required]
        public bool XMPProfile { get; set; }

        [Required]
        public bool AMPProfile { get; set; }

        [Required]
        public bool Cooling { get; set; }

        [Required]
        public bool LowProfileLevel { get; set; }

        [Required]
        public bool ErrorCorrectionCoding { get; set; }

        [Required]
        public int Frequency { get; set; }

        [Required]
        public int? RAMTypeId { get; set; }

        [ForeignKey("RAMTypeId")]
        public virtual RAMType RAMType { get; set; }

        [Required]
        public int? RAMModelId { get; set; }

        [ForeignKey("RAMTypeId")]
        public virtual RAMModel RAMModel { get; set; }

        [Required]
        public int RAMCount { get; set; } 

        [Required]
        public double RAMSupplyVoltage { get; set; }
       }
}

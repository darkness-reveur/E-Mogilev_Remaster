using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Computers.Cummon.ImputModelsDatas.ComputerComponents.RAM.HelperTypes
{
    public class RAMModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public int RAMBrandId { get; set; }

        [ForeignKey("RAMBrandId")]
        public virtual RAMBrand RAMBrand { get; set; }
    }
}

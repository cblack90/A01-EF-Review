using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("ManifesItems")]
    public class ManifestItem
    {
        [Key]
        public int ManifestItemID { get; set; }
        public int ShipmentID { get; set; }//FK
        public int ProductID { get; set; }//FK
        public int ShipQuantity { get; set; }
    }
}

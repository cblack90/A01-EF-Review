using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Territories")]
    public class Territory
    {
        [Key]
        [StringLength(20, ErrorMessage = "TerritoryID cannot be more than 20 characters in length")]
        public string TerritoryID { get; set; }

        [Required, StringLength(50, ErrorMessage = "Territory Description cannot be more than 50 characters in length")]
        public string TerritoryDescription { get; set; }
        [Required]
        public int RegionID { get; set; }
    }
}

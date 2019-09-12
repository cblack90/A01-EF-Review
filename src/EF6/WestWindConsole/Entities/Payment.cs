using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Payments")]
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public int PaymentTypeID { get; set; } //double check FK
        [Required]
        public int OrderID { get; set; }
        [Required]
        public Guid TransactionID { get; set; } 
        public DateTime ClearedDate { get; set; }
    }
}

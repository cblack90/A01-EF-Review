using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("PaymentTypes")]
    public class PaymentType
    {
        [Key]
        public int PaymentTypeID { get; set; }

        [StringLength(40, ErrorMessage = "Payment Type Description cannot be more than 40 characters in length")]
        public string PaymentTyupeDescription { get; set; }
    }
}

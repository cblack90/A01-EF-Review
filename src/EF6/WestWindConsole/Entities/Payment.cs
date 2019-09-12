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

        public DateTime PaymentDate { get; set; }

        public double Amount { get; set; }
        public int PaymentTypeID { get; set; } //double check FK
        public int OrederID { get; set; }//FK
        public int TransactionID { get; set; } //ERD has labled as uniqueidentifier
        public DateTime ClearedDate { get; set; }
    }
}

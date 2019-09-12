﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int SalesRepID { get; set; }//FK
        [StringLength(5, ErrorMessage = "CustomerID cannot be more than 5 characters in length")]
        public string CustomerID { get; set; }//FK
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public double Freight { get; set; }
        public bool Shipped { get; set; }
        [StringLength(40, ErrorMessage = "Ship Name cannot be more than 40 characters in length")]
        public string ShipName { get; set; }
        public int ShipAddressID { get; set; }
        [StringLength(250, ErrorMessage = "Comments cannot be more than 250 characters in length")]
        public string Comments { get; set; }
    }
}

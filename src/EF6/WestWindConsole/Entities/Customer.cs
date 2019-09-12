using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [StringLength(5, ErrorMessage = "CustomerID cannot be more than 5 characters in length")]
        public string CustomerID { get; set; }

        [Required, StringLength(40, ErrorMessage = "Company Name cannot be more than 40 characters in length")]
        public string CompanyName { get; set; }

        [Required, StringLength(30, ErrorMessage = "Contact Name cannot be more than 30 characters in length")]
        public string ContactName { get; set; }

        [StringLength(30, ErrorMessage = "Contact Title cannot be more than 30 characters in length")]
        public string ContactTitle { get; set; }

        [StringLength(50, ErrorMessage = "Contact Email cannot be more than 50 characters in length")] //look up email validation
        public string ContactEmail { get; set; }

        [Required, StringLength(60, ErrorMessage = "AddressID cannot be more than 60 characters in length")] //is this not a foreign Key
        public string AddressID { get; set; }

        [Required, StringLength(24, ErrorMessage = "Phone Number cannot be more than 24 characters in length")] // look up phone formating
        public string Phone { get; set; }

        [StringLength(24, ErrorMessage = "Fax Number cannot be more than 24 characters in length")] //phone formatting
        public string Fax { get; set; }
    }
}

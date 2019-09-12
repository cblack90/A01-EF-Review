using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WestWindConsole.Entities;

namespace WestWindConsole
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [Required, StringLength(60, ErrorMessage ="Address cannot be more than 60 characters in length")] 
        [Column("Address")]//maps to the db column Address
        public string StreetAddress { get; set; }

        [Required, StringLength(15, ErrorMessage = "City cannot be more than 15 characters in length")]
        public string City { get; set; }

        [StringLength(15, ErrorMessage = "Region cannot be more than 15 characters in length")]
        public string Region { get; set; }

        [StringLength(10, ErrorMessage = "Postal Code cannot be more than 10 characters in length")] //look up formating for this
        public string PostalCode { get; set; }

        [Required, StringLength(15, ErrorMessage = "Country cannot be more than 15 characters in length")]
        public string Country { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; } =
            new HashSet<Supplier>();

        public virtual ICollection<Customer> Customers { get; set; } =
            new HashSet<Customer>();

        public virtual ICollection<Employee> Employees { get; set; } =
            new HashSet<Employee>();
    }
}

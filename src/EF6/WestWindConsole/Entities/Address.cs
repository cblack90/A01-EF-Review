using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WestWindConsole
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [StringLength(60, ErrorMessage ="Address cannot be more than 60 characters in length")] //have to figure outname.... might be not mapped
        public string Address { get; set; }

        [StringLength(15, ErrorMessage = "City cannot be more than 15 characters in length")]
        public string City { get; set; }

        [StringLength(15, ErrorMessage = "Region cannot be more than 15 characters in length")]
        public string Region { get; set; }

        [StringLength(10, ErrorMessage = "Postal Code cannot be more than 10 characters in length")] //look up formating for this
        public string PostalCode { get; set; }

        [StringLength(15, ErrorMessage = "Country cannot be more than 15 characters in length")]
        public string Country { get; set; }
    }
}

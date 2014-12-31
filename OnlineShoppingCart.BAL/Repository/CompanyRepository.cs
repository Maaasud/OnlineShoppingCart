using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class CompanyRepository
    {
        public int CompanyID { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public int ContactID { get; set; }

        public int AddressID { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
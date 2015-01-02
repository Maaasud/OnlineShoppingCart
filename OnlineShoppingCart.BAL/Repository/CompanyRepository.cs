
namespace OnlineShoppingCart.BAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using OnlineShoppingCart.DAL;

    public class CompanyRepository
    {
        public int CompanyID { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public string CompanyName { get; set; }

        public int ContactID { get; set; }

        public Contact Contact { get; set; }

        public int AddressID { get; set; }

        public Address Address { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
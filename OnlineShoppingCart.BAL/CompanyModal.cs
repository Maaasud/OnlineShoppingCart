using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class CompanyModal
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CompanyID { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public int ContactID { get; set; }
        public int AddressID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
    }
}
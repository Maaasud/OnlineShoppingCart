using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class UserModal
    {
        [Key]
        [ScaffoldColumn (false)]
        public int UserID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required]
        public Nullable<int> ContactID { get; set; }

        [Required]
        public Nullable<int> CreditCardID { get; set; }

        public Nullable<int> AddressID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> UserTypeID { get; set; }
        public Nullable<int> UserRoleID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
    }
}
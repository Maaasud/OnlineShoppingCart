using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class User
    {
        public int UserID { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "You can't leave this empty.")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        [DataType(DataType.Password)]
        [DisplayName("Create a password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm your password")]
        [Compare("Password", ErrorMessage = "These passwords don't match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public Contact Contact { get; set; }

        public CreditCard CreditCardID { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public Address Address { get; set; }

        public Company Company { get; set; }

        public UserType UserType { get; set; }

        public UserRole UserRole { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
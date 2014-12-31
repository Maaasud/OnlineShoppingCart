using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class UserRepository
    {
        public int UserID { get; set; }

        [DisplayName("My fullname is")]
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

        public ContactRepository Contact { get; set; }

        public CreditCardRepository CreditCard { get; set; }

        public AddressRepository Address { get; set; }

        public CompanyRepository Company { get; set; }

        public UserTypeRepository UserType { get; set; }

        public UserRoleRepository UserRole { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
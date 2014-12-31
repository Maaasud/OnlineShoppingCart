using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class ContactRepository
    {
        public int ContactID { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [DisplayName("Enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        [DataType(DataType.EmailAddress)]
        [Compare("Email", ErrorMessage = "These email don't match.")]
        [DisplayName("Confirm your email")]
        public string ConfirmEmail { get; set; }

        [DisplayName("Phone(Optional)")]
        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Website { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }

    }
}
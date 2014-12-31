using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class CreditCardRepository
    {
        public int CreditCardID { get; set; }

        [Required(ErrorMessage = "Card number is Required")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Expiration date is Required")]
        public System.DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage = "CSC code is Required")]
        public string CSC { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
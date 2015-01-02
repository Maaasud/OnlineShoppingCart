
namespace OnlineShoppingCart.BAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using OnlineShoppingCart.DAL;

    public class CreditCardRepository
    {
        public int CreditCardID { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public System.DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public string CSC { get; set; }

        public int CardTypeID { get; set; }

        public CardType CartType { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class CreditCardModal
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CreditCardID { get; set; }

       [Required(ErrorMessage="CardNumber is Required")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage="Expiration Date is Required")]
        public System.DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage="CSC code is Required")]
        public string CSC { get; set; }

        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
    }
}
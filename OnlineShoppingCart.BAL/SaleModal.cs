using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class SaleModal
    {
        [Key]
        [ScaffoldColumn(false)]
        public int SalesID { get; set; }

        [Required]
        public int ProductID { get; set; }

        public int UserID { get; set; }
        public Nullable<int> UnitSold { get; set; }
        public Nullable<int> Amount { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
    }
}
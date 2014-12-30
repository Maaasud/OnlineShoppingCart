using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class CartModal
    {
        [Key]
        [ScaffoldColumn(false)]

        public int CartID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> UnitCount { get; set; }
        public int UserID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }

    }
}
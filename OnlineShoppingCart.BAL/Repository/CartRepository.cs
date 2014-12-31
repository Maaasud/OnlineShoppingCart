using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class CartRepository
    {
        public int CartID { get; set; }
		
        public int ProductID { get; set; }
		
        public int UnitCount { get; set; }
		
        public int UserID { get; set; }
		
        public DateTime DateCreated { get; set; }
		
        public DateTime DateModified { get; set; }
		
        public DateTime DateDeleted { get; set; }

    }
}
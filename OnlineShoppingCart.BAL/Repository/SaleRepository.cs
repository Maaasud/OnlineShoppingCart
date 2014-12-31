using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class SaleRepository
    {
		public int SalesID { get; set; }
		
        public int ProductID { get; set; }
		
        public int UserID { get; set; }
		
        public int UnitSold { get; set; }
		
        public int Amount { get; set; }
		
        public DateTime DateCreated { get; set; }
		
        public DateTime DateModified { get; set; }
		
        public DateTime DateDeleted { get; set; }
    }
}
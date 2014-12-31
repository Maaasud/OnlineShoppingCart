using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class SubCategoryRepository
    {
		public int SubCategoryID { get; set; }
		
        public int CategoryID { get; set; }
		
        public string Name { get; set; }
		
        public string Description { get; set; }
		
        public DateTime DateCreated { get; set; }
		
        public DateTime DateModified { get; set; }
		
        public DateTime DateDeleted { get; set; }
    }
}
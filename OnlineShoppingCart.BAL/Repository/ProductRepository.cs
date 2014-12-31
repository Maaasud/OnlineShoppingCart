using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class ProductRepository
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage="Product name is required")]
        public string Name { get; set; }

        public string Description { get; set; }
		
        public int CompanyID { get; set; }
		
        public int CategoryID { get; set; }
		
        public int SubCategoryID { get; set; }
		
        public int UserID { get; set; }
		
        public int Quantity { get; set; }
		
        public int QunatityInStock { get; set; }
		
        public int UnitPrice { get; set; }
		
        public string Image { get; set; }
		
        public bool IsPosted { get; set; }
		
        public DateTime DateCreated { get; set; }
		
        public DateTime DateModified { get; set; }
		
        public DateTime DateDeleted { get; set; }

    }
}
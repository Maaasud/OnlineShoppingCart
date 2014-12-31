using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class ProductModal
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage="Product Name is Required")]
        public string Name { get; set; }

        public string Description { get; set; }
        public int CompanyID { get; set; }
        public int CategoryID { get; set; }
        public Nullable<int> SubCategoryID { get; set; }
        public int UserID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> QunatityInStock { get; set; }
        public Nullable<int> UnitPrice { get; set; }
        public string Image { get; set; }
        public Nullable<bool> IsPosted { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }

    }
}
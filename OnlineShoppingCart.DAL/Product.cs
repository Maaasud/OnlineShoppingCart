//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShoppingCart.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Cart = new HashSet<Cart>();
            this.Sale = new HashSet<Sale>();
        }
    
        public int ProductID { get; set; }
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
    
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
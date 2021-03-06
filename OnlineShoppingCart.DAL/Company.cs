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
    
    public partial class Company
    {
        public Company()
        {
            this.Product = new HashSet<Product>();
            this.Users = new HashSet<Users>();
        }
    
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public int ContactID { get; set; }
        public string Logo { get; set; }
        public Nullable<int> RateStar { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}

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
    
    public partial class CreditCard
    {
        public CreditCard()
        {
            this.Users = new HashSet<Users>();
        }
    
        public int CreditCardID { get; set; }
        public string CardNumber { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public string CSC { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
    
        public virtual ICollection<Users> Users { get; set; }
    }
}
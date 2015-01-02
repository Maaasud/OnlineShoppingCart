
namespace OnlineShoppingCart.BAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using OnlineShoppingCart.DAL;

    public class OrderRepository
    {
        public int OrderID { get; set; }

        public int UserID { get; set; }

        public Users User { get; set; }

        public int TotalPrice { get; set; }

        public bool IsCheckout { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
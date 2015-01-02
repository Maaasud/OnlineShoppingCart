
namespace OnlineShoppingCart.BAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using OnlineShoppingCart.DAL;

    public class OrderItemRepository
    {
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }

        public Order Order { get; set; }

        public int ProductID { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
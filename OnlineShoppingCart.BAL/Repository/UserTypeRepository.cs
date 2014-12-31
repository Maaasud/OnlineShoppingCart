using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class UserTypeRepository
    {
        public int UserTypeID { get; set; }

        public string TypeName { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
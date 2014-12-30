using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class User
    {
        public int UserID { get; set; }

        public int FirstName { get; set; }

        public int LastName { get; set; }

        public int Password { get; set; }

        public int ContactID { get; set; }

        public int CreditCardID { get; set; }

        public int AddressID { get; set; }

        public int CompanyID { get; set; }

        public int UserTypeID { get; set; }

        public int UserRoleID { get; set; }

        public int IsActive { get; set; }

        public int DateCreated { get; set; }

        public int DateModified { get; set; }

        public int DateDeleted { get; set; }
    }
}
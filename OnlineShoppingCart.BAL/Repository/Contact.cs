using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class Contact
    {
        public int ContactID { get; set; }


        public string Email { get; set; }
        
        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Website { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }

    }
}
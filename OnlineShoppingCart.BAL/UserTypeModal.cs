using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class UserTypeModal
    {
        [Key]
        [ScaffoldColumn(false)]
        public int UserTypeID { get; set; }

        public string TypeName { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
    }
}
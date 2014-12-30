using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class SettingModal
    {
        [Key]
        [ScaffoldColumn(false)]
        public int SettingID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Value { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
    }
}
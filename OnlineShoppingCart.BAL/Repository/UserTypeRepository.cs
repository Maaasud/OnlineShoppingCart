
namespace OnlineShoppingCart.BAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class UserTypeRepository
    {
        public int UserTypeID { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public string TypeName { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
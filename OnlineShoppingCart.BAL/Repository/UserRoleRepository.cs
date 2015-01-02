
namespace OnlineShoppingCart.BAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class UserRoleRepository
    {
        public int UserRoleID { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
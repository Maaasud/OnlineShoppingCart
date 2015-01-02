
namespace OnlineShoppingCart.BAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using OnlineShoppingCart.DAL;
    using System.ComponentModel.DataAnnotations;

    public class CardTypeRepository : CardType
    {
        public int CardTypeID { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public string Type { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
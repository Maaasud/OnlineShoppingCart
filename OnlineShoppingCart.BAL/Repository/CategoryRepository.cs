﻿
namespace OnlineShoppingCart.BAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using OnlineShoppingCart.DAL;

    public class CategoryRepository
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "You can't leave this empty.")]
        public string Name { get; set; }

        public int UserID { get; set; }

        public Users User { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }

    }
}
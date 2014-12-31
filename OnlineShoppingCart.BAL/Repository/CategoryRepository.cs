using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL
{
    public class CategoryRepository
    {
        public int CategoryID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
		
        public DateTime DateCreated { get; set; }
		
        public DateTime DateModified { get; set; }
		
        public DateTime DateDeleted { get; set; }

    }
}
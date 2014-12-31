using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingCart.BAL.Repository
{
    public class SettingRepository
    {
		public int SettingID { get; set; }
		
        public string Name { get; set; }
		
        public string Value { get; set; }
		
        public DateTime DateCreated { get; set; }
		
        public DateTime DateModified { get; set; }
		
        public DateTime DateDeleted { get; set; }
    }
}
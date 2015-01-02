
namespace OnlineShoppingCart.BAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class ContactRepository
    {
        public int ContactID { get; set; }

        [DisplayName("Phone(Optional)")]
        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Website { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateDeleted { get; set; }

    }
}

namespace OnlineShoppingCart.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using OnlineShoppingCart.DAL;
    using OnlineShoppingCart.Model;

    public class SignUpController : Controller
    {
        private OnlineShoppingCartDbContext _dbContext;

        public SignUpController(OnlineShoppingCartDbContext context)
        {
            _dbContext = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult Save(UserModel userModel)
        {
            int userID = 0;
            if (ModelState.IsValid)
            {
                //save here
                if (new UserModel(this._dbContext).Save(userModel, out userID))
                {
                    ViewBag.Message = "User inserted successfully";
                }
            }

            return View("Index");
        }

        public ActionResult Login()
        {
            string emailId = Request.Form["textboxEmail"];
            string password = Request.Form["textboxPassword"];
            return RedirectToAction("", "Home");
        }
    }
}
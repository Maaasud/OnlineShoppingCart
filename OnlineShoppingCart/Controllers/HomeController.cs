using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingCart.DAL;
using OnlineShoppingCart.Model;

namespace OnlineShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        OnlineShoppingCartDbContext _dbContext;
        //
        // GET: /Default/
        public HomeController(OnlineShoppingCartDbContext context)
        {
            _dbContext = new OnlineShoppingCartDbContext();
        }

        public ActionResult Index()
        {
            UserModel userModel = new UserModel(_dbContext);
            return View();
        }
	}
}
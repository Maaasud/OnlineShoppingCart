using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingCart.DAL;

namespace OnlineShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        OnlineShoppingCartDbContext _dbContext;
        //
        // GET: /Default/
        public HomeController(OnlineShoppingCartDbContext context)
        {
            _dbContext = context;
        }

        public ActionResult Index()
        {
            return View();
        }
	}
}
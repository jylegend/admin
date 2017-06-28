using Soul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soul.Controllers
{
    public class ProductsController : Controller
    {
        ExchangeActionConfigDbContext c = new ExchangeActionConfigDbContext();
        //
        // GET: /Products/

        public ActionResult Index(string searchStr)
        {
            List<Product> list = new List<Product>();
            list = c.Product.ToList();
            if (!string.IsNullOrEmpty(searchStr))
            {
                list = list.Where(a => a.Name.Contains(searchStr)).ToList<Product>();
            }
            return View(list);
        }

    }
}

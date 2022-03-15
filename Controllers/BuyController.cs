using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class BuyController : Controller
    {

        public BuyController ()
        {

        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Buy());
        }

        [HttpPost]
        public IActionResult Checkout(Buy buy)
        {

        }
    }
}

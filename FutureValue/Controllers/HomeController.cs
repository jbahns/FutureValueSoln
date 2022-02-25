using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Mary";
            ViewBag.FV = 99999.99;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Models.FutureValue model)
        {
            ViewBag.FV = model.CalculatedFutureValue();
            return View(model);
        }


    }
}

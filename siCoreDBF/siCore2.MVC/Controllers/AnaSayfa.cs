using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siCore2.MVC.Controllers
{

    public class AnaSayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
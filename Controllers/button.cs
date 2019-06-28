using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace buttonTest.Controllers
{
    public class button : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = "Your application description page. aaron smells";
            return View();
        }

        public IActionResult check(string button)
        {
            if(button == "first")
            {
                TempData["buttonval"] = "First button clicked";
            }
            else
            {
                TempData["buttonval"] = "Second button clicked";
            }

            return RedirectToAction("Index");
        }
    }
}

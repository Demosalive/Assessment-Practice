using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mock_Assessment_5.Models;

namespace Mock_Assessment_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Result(int num1, int num2, string operation)
        {
            int result = -1;
            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "/")
            {
                result = num1 / num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            //will display whatever we want provided it has viewbag infront
            ViewBag.Result = result;
            ViewBag.Operation = operation;
            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;

            return View();
        }

        public IActionResult List()
        {
            List<int> nums = new List<int> { 10, 29, 22, 43, 19, 7 };

            return View(nums);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

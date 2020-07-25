using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetcore_AdminatorTemplate.Models;

namespace dotnetcore_AdminatorTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Email() => View();
        public IActionResult Compose() => View();
        public IActionResult Calendar() => View();
        public IActionResult Chat() => View();
        public IActionResult Charts() => View();
        public IActionResult Forms() => View();
        public IActionResult Ui() => View();
        public IActionResult BasicTable() => View();
        public IActionResult DataTable() => View();
        public IActionResult GoogleMaps() => View();
        public IActionResult VectorMaps() => View();
        public IActionResult Blank() => View();
        public IActionResult Page404() => View();
        public IActionResult Page500() => View();
        public IActionResult SignIn() => View();
        public IActionResult SignUp() => View();
    }
}

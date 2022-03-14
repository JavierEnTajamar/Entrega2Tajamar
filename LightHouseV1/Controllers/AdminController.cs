using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightHouseV1.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles = "Lightkeeper")]

        public IActionResult Main()
        {
            return View();
        }
    }
}

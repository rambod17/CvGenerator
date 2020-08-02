using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CG.Web.Controllers
{
    public class CvsController : Controller
    {
        public IActionResult MyCvs()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult SocialImport()
        {
            return View();
        }
    }
}

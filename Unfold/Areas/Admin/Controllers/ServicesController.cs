using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unfold.Areas.Admin;

namespace Unfold.Controllers.Admin
{
    public class ServicesController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ServicesEditing()
        {
            return View();
        }
    }
}

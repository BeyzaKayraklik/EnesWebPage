using DataBaseEntity.Transaction;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unfold.Controllers
{
    public class Project : Controller
    {
        public IActionResult Index(string id)
        {

            PortfolioTbl project = new PortfolioTbl();
            var x = Convert.ToInt32(id);

            var a = project.Select(x);

            ViewData["project"] = a;
            return View();
        }
    }
}

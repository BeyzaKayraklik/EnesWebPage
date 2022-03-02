using DataBaseEntity.Transaction;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unfold.Controllers
{
    public class CategoriesDetail : Controller
    {
        public IActionResult Index(int id)
        {

            PortfolioTbl project = new PortfolioTbl();
             var a = project.DataSource(id);
            ViewData["categories"] = a;
             
            return View();
        }
    }
}

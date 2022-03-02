using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unfold.Areas.Admin;
using DataBaseEntity;
namespace Unfold.Controllers.Admin
{
    public class PortfolioController : AdminBaseController
    {
        public IActionResult Index(string id)
        {
            //DataBaseEntity.
            //PortfolioTbl portfolio = new PortfolioTbl();
            //var a = portfolio.Select(id);
            //ViewData["portfolio"] = a;

            return View();
        }
        public IActionResult PortfolioEditing()
        {
            return View();
        }
    }
}

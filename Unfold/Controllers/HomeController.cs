using DataBaseEntity.Transaction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Unfold.Models;

namespace Unfold.Controllers
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
            CategoriesTbl categories = new CategoriesTbl();

            var c = categories.DataSource();

            ViewData["categories"] = c;


            ProjectTbl project = new ProjectTbl();

            var a = project.DataSource();

            ViewData["project"] = a;


            SliderTbl slider = new SliderTbl();

            var b = slider.DataSource();

            ViewData["slider"] = b;


           AboutTbl about = new AboutTbl();

            var d = about.DataSource();

            ViewData["about"] = d;


            ServicesTbl services = new ServicesTbl();

            var e = services.DataSource();

            ViewData["services"] = e;


            SkillsTbl skills = new SkillsTbl();

            var f = skills.DataSource();

            ViewData["skills"] = f;


            ContactTbl contact = new ContactTbl();

            var g = contact.DataSource();

            ViewData["contact"] = g;


            return View();
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

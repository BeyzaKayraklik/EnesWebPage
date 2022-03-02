using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unfold.Areas.Admin;
using DataBaseEntity.Transaction;

namespace Unfold.Controllers.Admin
{
    public class CategoriesController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoriesEditing()
        {
            return View();
        }
    }
}

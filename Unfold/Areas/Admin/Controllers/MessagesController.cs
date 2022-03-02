using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unfold.Areas.Admin;

namespace Unfold.Controllers.Admin
{
    public class MessagesController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MessagesEditing()
        {
            return View();
        }
    }
}

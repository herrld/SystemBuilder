using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SystemBuilderAPI.Controllers
{
    public class UserInterfaceBuilderController : Controller
    {
        // GET: UserInterfaceBuilder
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult CanvasArea()
        {
            return PartialView();
        }
    }
}
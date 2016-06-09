using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers {
    public class GoogleAccountController : Controller {
        
        public ActionResult Login() {
            return View();
        }
    }
}
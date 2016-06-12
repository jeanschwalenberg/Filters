using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters.App_Start;
using Filters.Infrastructure;

namespace Filters.Controllers {
    [SimpleMessage(Message = "A")]
    public class CustomerController : Controller {

        public string Index() {
            return "This is the customer controller";
        }

        [SimpleMessage(Message = "B")]
        public string OtherAction() {
            return "This is the Other Action in the Customer controller";
        }
    }
}
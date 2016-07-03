using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingWebMvc.Controllers
{
    public class FinancialStoreController : Controller
    {
        // GET: FinancialStore
        public ActionResult Index()
        {
            return View();
        }
    }
}
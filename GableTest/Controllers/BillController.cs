using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GableTest.Models;
using GableTest.Helper;

namespace GableTest.Models
{
    public class BillController : Controller
    {
        // GET: Bill
        protected BillHelper billHelp = new BillHelper();
        public ActionResult Bill()
        {
            return View();
        }
        public ActionResult GetBillList()
        {
            try
            {
                var GetBillList = billHelp.GetBillList();
                var list = billHelp.GetBillList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GableTest.Models;
using GableTest.Helper;

namespace GableTest.Controllers
{
    public class TypeController : Controller
    {
        // GET: Type
        protected TypeHelper typeHelp = new TypeHelper();
        public ActionResult Type()
        {
            return View();
        }
        public ActionResult GetTypeList()
        {
            try
            {
                var typeList = typeHelp.GetTypeList();
                var list = typeList.Select(m => new
                {
                    TYPE_M_TEST_ID = m.TYPE_M_TEST_ID,
                    TYPE_M_TEST_NAME = m.TYPE_M_TEST_NAME,
                    TYPE_M_TEST_TIMESTMP = m.TYPE_M_TEST_TIMESTMP,
                    TYPE_M_TEST_ACTIVE = m.TYPE_M_TEST_ACTIVE
                }).ToList();

                return Json(list, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
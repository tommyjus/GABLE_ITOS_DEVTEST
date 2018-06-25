using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GableTest.Models;
using GableTest.Helper;

namespace GableTest.Controllers
{
    public class StatController : Controller
    {
        // GET: Stat
        protected StatHelper statHelp = new StatHelper();
        public ActionResult Stat()
        {
            return View();
        }

        public ActionResult GetStatList()
        {
            try
            {
                var statList = statHelp.GetStatList();
                var list = statList.Select(o => new
                {
                    STAT_M_TEST_ID = o.STAT_M_TEST_ID,
                    STAT_M_TEST_NAME = o.STAT_M_TEST_NAME,
                    STAT_M_TEST_TIMESTMP = o.STAT_M_TEST_TIMESTMP,
                    STAT_M_TEST_ACTIVE = o.STAT_M_TEST_ACTIVE
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
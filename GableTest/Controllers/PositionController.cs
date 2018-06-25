using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GableTest.Models;
using GableTest.Helper;

namespace GableTest.Controllers
{
    public class PositionController : Controller
    {
        // GET: Position
        protected PositionHelper poHelp = new PositionHelper();
        public ActionResult Position()
        {
            return View();
        }

        public ActionResult GetPositionList()
        {
            try
            {
                var positionList = poHelp.GetPositionList();
                var list = positionList.Select(m => new
                {
                    POSI_M_TEST_ID = m.POSI_M_TEST_ID,
                    POSI_M_TEST_NAME = m.POSI_M_TEST_NAME,
                    POSI_M_TEST_TIMESTMP = m.POSI_M_TEST_TIMESTMP,
                    POSI_M_TEST_ACTINE = m.POSI_M_TEST_ACTINE
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
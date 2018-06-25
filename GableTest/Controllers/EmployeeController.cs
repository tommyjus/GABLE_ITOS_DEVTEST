using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GableTest.Models;
using GableTest.Helper;


namespace GableTest.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        protected EmployeeHelper emHelp = new EmployeeHelper();
        public ActionResult Employee()
        {
            return View();
        }
        public ActionResult GetEmployeeList()
        {
            try
            {
                var employeeList = emHelp.GetEmployeeList();
                var list = employeeList.Select(o => new
                {
                    EMP_T_TEST_ID = o.EMP_T_TEST_ID,
                    POSI_M_TEST_ID = o.POSI_M_TEST_ID,
                    EMP_T_TEST_NAME = o.EMP_T_TEST_NAME,
                    EMP_T_TEST_SURNAME = o.EMP_T_TEST_SURNAME,
                    EMP_T_TEST_TELL = o.EMP_T_TEST_TELL,
                    EMP_T_TEST_EMAIL = o.EMP_T_TEST_EMAIL,
                    EMP_T_TEST_ACTIVE = o.EMP_T_TEST_ACTIVE
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
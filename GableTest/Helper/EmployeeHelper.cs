using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GableTest.Entities;
using GableTest.Library;
using GableTest.Models;

namespace GableTest.Helper
{
    public class EmployeeHelper
    {
        public List<EmployeeModel> GetEmployeeList()
        {
            return new EmployeeLibrary().GetEmployeeList();
        }
    }
}
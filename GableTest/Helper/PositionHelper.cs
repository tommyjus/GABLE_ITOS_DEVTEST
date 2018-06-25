using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GableTest.Library;
using GableTest.Models;

namespace GableTest.Helper
{
    public class PositionHelper
    {
        public List<PositionModel> GetPositionList()
        {
            return new PositionLibrary().GetPositionList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GableTest.Models;
using GableTest.Entities;

namespace GableTest.Library
{
    public class PositionLibrary
    {
        gable_testEntities db = new gable_testEntities();

        public IQueryable<posi_m_test> IQueryablePo()
        {
            return db.posi_m_test;
        }

        internal posi_m_test Mapping(PositionModel m)
        {
            try
            {
                if (m != null)
                {
                    return new posi_m_test()
                    {
                        POSI_M_TEST_ID = m.POSI_M_TEST_ID,
                        POSI_M_TEST_NAME = m.POSI_M_TEST_NAME,
                        POSI_M_TEST_TIMESTMP = m.POSI_M_TEST_TIMESTMP,
                        POSI_M_TEST_ACTINE = m.POSI_M_TEST_ACTINE
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal PositionModel Mapping(posi_m_test m)
        {
            try
            {
                if (m != null)
                {
                    return new PositionModel()
                    {
                        POSI_M_TEST_ID = m.POSI_M_TEST_ID,
                        POSI_M_TEST_NAME = m.POSI_M_TEST_NAME,
                        POSI_M_TEST_TIMESTMP = (DateTime)m.POSI_M_TEST_TIMESTMP,
                        POSI_M_TEST_ACTINE = m.POSI_M_TEST_ACTINE
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<posi_m_test> Mapping(List<PositionModel> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<posi_m_test> emList = new List<posi_m_test>();
                    foreach (PositionModel m in list)
                    {
                        emList.Add(new posi_m_test()
                        {
                            POSI_M_TEST_ID = m.POSI_M_TEST_ID,
                            POSI_M_TEST_NAME = m.POSI_M_TEST_NAME,
                            POSI_M_TEST_TIMESTMP = m.POSI_M_TEST_TIMESTMP,
                            POSI_M_TEST_ACTINE = m.POSI_M_TEST_ACTINE
                        });
                    }
                    return emList;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PositionModel> Mapping(List<posi_m_test> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<PositionModel> emList = new List<PositionModel>();
                    foreach (posi_m_test m in list)
                    {
                        emList.Add(new PositionModel()
                        {
                            POSI_M_TEST_ID = m.POSI_M_TEST_ID,
                            POSI_M_TEST_NAME = m.POSI_M_TEST_NAME,
                            POSI_M_TEST_TIMESTMP = (DateTime)m.POSI_M_TEST_TIMESTMP,
                            POSI_M_TEST_ACTINE = m.POSI_M_TEST_ACTINE
                        });
                    }
                    return emList;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal List<PositionModel> GetPositionList()
        {
            try
            {
                List<posi_m_test> e = IQueryablePo().Where(o => o.POSI_M_TEST_NAME.Contains("Programmer")).ToList();
                List<PositionModel> eList = Mapping(e);
                return eList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }   
}
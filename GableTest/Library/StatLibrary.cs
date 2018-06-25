using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GableTest.Models;
using GableTest.Entities;

namespace GableTest.Library
{
    public class StatLibrary
    {
        gable_testEntities db = new gable_testEntities();
        public IQueryable<stat_m_test> IQueryableStat()
        {
            return db.stat_m_test;
        }

        internal stat_m_test Mapping(StatModel m)
        {
            try
            {
                if (m != null)
                {
                    return new stat_m_test()
                    {
                        STAT_M_TEST_ID = m.STAT_M_TEST_ID,
                        STAT_M_TEST_NAME = m.STAT_M_TEST_NAME,
                        STAT_M_TEST_TIMESTMP = m.STAT_M_TEST_TIMESTMP,
                        STAT_M_TEST_ACTIVE = m.STAT_M_TEST_ACTIVE
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal StatModel Mapping(stat_m_test m)
        {
            try
            {
                if (m != null)
                {
                    return new StatModel()
                    {
                        STAT_M_TEST_ID = m.STAT_M_TEST_ID,
                        STAT_M_TEST_NAME = m.STAT_M_TEST_NAME,
                        STAT_M_TEST_TIMESTMP = m.STAT_M_TEST_TIMESTMP,
                        STAT_M_TEST_ACTIVE = m.STAT_M_TEST_ACTIVE
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<stat_m_test> Mapping(List<StatModel> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<stat_m_test> emList = new List<stat_m_test>();
                    foreach (StatModel m in list)
                    {
                        emList.Add(new stat_m_test()
                        {
                            STAT_M_TEST_ID = m.STAT_M_TEST_ID,
                            STAT_M_TEST_NAME = m.STAT_M_TEST_NAME,
                            STAT_M_TEST_TIMESTMP = m.STAT_M_TEST_TIMESTMP,
                            STAT_M_TEST_ACTIVE = m.STAT_M_TEST_ACTIVE
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

        public List<StatModel> Mapping(List<stat_m_test> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<StatModel> emList = new List<StatModel>();
                    foreach (stat_m_test m in list)
                    {
                        emList.Add(new StatModel()
                        {
                            STAT_M_TEST_ID = m.STAT_M_TEST_ID,
                            STAT_M_TEST_NAME = m.STAT_M_TEST_NAME,
                            STAT_M_TEST_TIMESTMP = m.STAT_M_TEST_TIMESTMP,
                            STAT_M_TEST_ACTIVE = m.STAT_M_TEST_ACTIVE
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

        internal List<StatModel> GetStatList()
        {
            try
            {
                List<stat_m_test> e = IQueryableStat().ToList();
                List<StatModel> eList = Mapping(e);
                return eList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
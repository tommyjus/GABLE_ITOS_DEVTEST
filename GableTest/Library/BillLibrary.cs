using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GableTest.Models;
using GableTest.Entities;

namespace GableTest.Library
{
    public class BillLibrary
    {
        gable_testEntities db = new gable_testEntities();

        public IQueryable<bill_t_test> IQueryableBill()
        {
            return db.bill_t_test;
        }

        public IQueryable<stat_m_test> IQueryableStat()
        {
            return db.stat_m_test;
        }

        internal bill_t_test Mapping(BillModel m)
        {
            try
            {
                if (m != null)
                {
                    return new bill_t_test()
                    {
                        BILL_T_TEST_ID = m.BILL_T_TEST_ID,
                        EMP_T_TEST_NAME = m.EMP_T_TEST_NAME,
                        EMP_T_TEST_ID = m.EMP_T_TEST_ID,
                        TYPE_M_TEST_ID = m.TYPE_M_TEST_ID,
                        STAT_M_TEST_ID = m.STAT_M_TEST_ID,
                        BILL_T_TES_VALUES =m.BILL_T_TES_VALUES,
                        BILL_T_TEST_DATE = m.BILL_T_TEST_DATE,
                        BILL_T_TEST_TIMESTMP = m.BILL_T_TEST_TIMESTMP,
                        BILL_T_TEST_ACTINE = m.BILL_T_TEST_ACTINE,
                        BILL_T_TEST_APPROVE_IDNAME = m.BILL_T_TEST_APPROVE_IDNAME
                        
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal BillModel Mapping(bill_t_test m)
        {
            try
            {
                if (m != null)
                {
                    return new BillModel()
                    {
                        BILL_T_TEST_ID = m.BILL_T_TEST_ID,
                        EMP_T_TEST_NAME = m.EMP_T_TEST_NAME,
                        EMP_T_TEST_ID = (int)m.EMP_T_TEST_ID,
                        TYPE_M_TEST_ID = (int)m.TYPE_M_TEST_ID,
                        STAT_M_TEST_ID = (int)m.STAT_M_TEST_ID,
                        BILL_T_TES_VALUES = (int)m.BILL_T_TES_VALUES,
                        BILL_T_TEST_DATE = (DateTime)m.BILL_T_TEST_DATE,
                        BILL_T_TEST_TIMESTMP = (DateTime)m.BILL_T_TEST_TIMESTMP,
                        BILL_T_TEST_ACTINE = m.BILL_T_TEST_ACTINE,
                        BILL_T_TEST_APPROVE_IDNAME = (int)m.BILL_T_TEST_APPROVE_IDNAME

                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<bill_t_test> Mapping(List<BillModel> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<bill_t_test> emList = new List<bill_t_test>();
                    foreach (BillModel m in list)
                    {
                        emList.Add(new bill_t_test()
                        {
                            BILL_T_TEST_ID = m.BILL_T_TEST_ID,
                            EMP_T_TEST_NAME = m.EMP_T_TEST_NAME,
                            EMP_T_TEST_ID = m.EMP_T_TEST_ID,
                            TYPE_M_TEST_ID = m.TYPE_M_TEST_ID,
                            STAT_M_TEST_ID = m.STAT_M_TEST_ID,
                            BILL_T_TES_VALUES = m.BILL_T_TES_VALUES,
                            BILL_T_TEST_DATE = m.BILL_T_TEST_DATE,
                            BILL_T_TEST_TIMESTMP = m.BILL_T_TEST_TIMESTMP,
                            BILL_T_TEST_ACTINE = m.BILL_T_TEST_ACTINE,
                            BILL_T_TEST_APPROVE_IDNAME = m.BILL_T_TEST_APPROVE_IDNAME
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

        public List<BillModel> Mapping(List<bill_t_test> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<BillModel> emList = new List<BillModel>();
                    foreach (bill_t_test m in list)
                    {
                        emList.Add(new BillModel()
                        {
                            BILL_T_TEST_ID = m.BILL_T_TEST_ID,
                            EMP_T_TEST_NAME = m.EMP_T_TEST_NAME,
                            EMP_T_TEST_ID = (int)m.EMP_T_TEST_ID,
                            TYPE_M_TEST_ID = (int)m.TYPE_M_TEST_ID,
                            //TYPE_M_TEST_NAME = m.TYPE_M_TEST_NAME,
                            STAT_M_TEST_ID = (int)m.STAT_M_TEST_ID,
                            STAT_M_TEST_NAME = m.EMP_T_TEST_NAME,
                            BILL_T_TES_VALUES = (int)m.BILL_T_TES_VALUES,
                            BILL_T_TEST_DATE = (DateTime)m.BILL_T_TEST_DATE,
                            BILL_T_TEST_TIMESTMP = (DateTime)m.BILL_T_TEST_TIMESTMP,
                            BILL_T_TEST_ACTINE = m.BILL_T_TEST_ACTINE,
                            BILL_T_TEST_APPROVE_IDNAME = (int)m.BILL_T_TEST_APPROVE_IDNAME

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

        internal List<BillModel> GetBillList()
        {
            try
            {
                List<bill_t_test> e = IQueryableBill().ToList();
                List<BillModel> list = (from b in db.bill_t_test
                                        join bt in db.type_m_test on b.TYPE_M_TEST_ID equals bt.TYPE_M_TEST_ID
                                        join bs in db.stat_m_test on b.STAT_M_TEST_ID equals bs.STAT_M_TEST_ID
                                        join em in db.emp_t_test on b.EMP_T_TEST_ID equals em.EMP_T_TEST_ID
                                        orderby b.BILL_T_TEST_ID
                                        select new BillModel
                                        {
                                            BILL_T_TEST_ID = b.BILL_T_TEST_ID,
                                            EMP_T_TEST_NAME = em.EMP_T_TEST_NAME,
                                            EMP_T_TEST_ID = em.EMP_T_TEST_ID,
                                            TYPE_M_TEST_ID = bt.TYPE_M_TEST_ID,
                                            TYPE_M_TEST_NAME = bt.TYPE_M_TEST_NAME,
                                            STAT_M_TEST_ID = bs.STAT_M_TEST_ID,
                                            STAT_M_TEST_NAME = bs.STAT_M_TEST_NAME,
                                            BILL_T_TES_VALUES = (int)b.BILL_T_TES_VALUES,
                                            BILL_T_TEST_DATE = (DateTime)b.BILL_T_TEST_DATE,
                                            BILL_T_TEST_TIMESTMP = (DateTime)b.BILL_T_TEST_TIMESTMP,
                                            BILL_T_TEST_ACTINE = b.BILL_T_TEST_ACTINE,
                                            BILL_T_TEST_APPROVE_IDNAME = (int)b.BILL_T_TEST_APPROVE_IDNAME

                                        }).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
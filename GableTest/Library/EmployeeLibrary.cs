using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GableTest.Models;
using GableTest.Entities;

namespace GableTest.Library
{
    public class EmployeeLibrary
    {
        gable_testEntities db = new gable_testEntities();
        public IQueryable<emp_t_test> IQueryableEmp()
        {
            return db.emp_t_test;
        }
        public IQueryable<posi_m_test> IQueryablePosi()
        {
            return db.posi_m_test;
        }

        
        internal EmployeeModel Mapping(emp_t_test m)
        {
            try
            {
                if (m != null)
                {
                    return new EmployeeModel()
                    {
                        EMP_T_TEST_ID = m.EMP_T_TEST_ID,
                        POSI_M_TEST_ID = (int)m.POSI_M_TEST_ID,
                        EMP_T_TEST_NAME = m.EMP_T_TEST_NAME,
                        EMP_T_TEST_SURNAME = m.EMP_T_TEST_SURNAME,
                        EMP_T_TEST_TELL = m.EMP_T_TEST_TELL,
                        EMP_T_TEST_EMAIL = m.EMP_T_TEST_EMAIL,
                        EMP_T_TEST_ACTIVE = m.EMP_T_TEST_ACTIVE
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal emp_t_test Mapping(EmployeeModel m)
        {
            try
            {
                if (m != null)
                {
                    return new emp_t_test()
                    {
                        EMP_T_TEST_ID = m.EMP_T_TEST_ID,
                        POSI_M_TEST_ID = m.POSI_M_TEST_ID,
                        EMP_T_TEST_NAME = m.EMP_T_TEST_NAME,
                        EMP_T_TEST_SURNAME = m.EMP_T_TEST_SURNAME,
                        EMP_T_TEST_TELL = m.EMP_T_TEST_TELL,
                        EMP_T_TEST_EMAIL = m.EMP_T_TEST_EMAIL,
                        EMP_T_TEST_ACTIVE = m.EMP_T_TEST_ACTIVE
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        internal List<EmployeeModel> GetEmployeeList()
        {
            try
            {
                List<emp_t_test> e = IQueryableEmp().Where(o=> o.EMP_T_TEST_NAME.Contains("อำนาจ")).ToList();
                List<EmployeeModel> eList = Mapping(e);
                return eList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     /* internal EmployeeModel Getemployee()
        {
            try
            {
                emp_t_test e = IQueryableEmp().Where(o => o.EMP_T_TEST_NAME.Contains("อ"))
                return e;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }*/

        public List<emp_t_test> Mapping(List<EmployeeModel> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<emp_t_test> emList = new List<emp_t_test>();
                    foreach (EmployeeModel m in list)
                    {
                        emList.Add(new emp_t_test()
                        {
                            EMP_T_TEST_ID = m.EMP_T_TEST_ID,
                            POSI_M_TEST_ID = (int)m.POSI_M_TEST_ID,
                            EMP_T_TEST_NAME = m.EMP_T_TEST_NAME,
                            EMP_T_TEST_SURNAME = m.EMP_T_TEST_SURNAME,
                            EMP_T_TEST_TELL = m.EMP_T_TEST_TELL,
                            EMP_T_TEST_EMAIL = m.EMP_T_TEST_EMAIL,
                            EMP_T_TEST_ACTIVE = m.EMP_T_TEST_ACTIVE
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

        public List<EmployeeModel> Mapping(List<emp_t_test> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<EmployeeModel> emList = new List<EmployeeModel>();
                    foreach (emp_t_test m in list)
                    {
                        emList.Add(new EmployeeModel()
                        {
                            EMP_T_TEST_ID = m.EMP_T_TEST_ID,
                            POSI_M_TEST_ID = (int)m.POSI_M_TEST_ID,
                            EMP_T_TEST_NAME = m.EMP_T_TEST_NAME,
                            EMP_T_TEST_SURNAME = m.EMP_T_TEST_SURNAME,
                            EMP_T_TEST_TELL = m.EMP_T_TEST_TELL,
                            EMP_T_TEST_EMAIL = m.EMP_T_TEST_EMAIL,
                            EMP_T_TEST_ACTIVE = m.EMP_T_TEST_ACTIVE
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


    }
}
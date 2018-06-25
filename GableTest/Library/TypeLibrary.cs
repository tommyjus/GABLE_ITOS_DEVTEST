using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GableTest.Models;
using GableTest.Entities;

namespace GableTest.Library
{
    public class TypeLibrary
    {
        gable_testEntities db = new gable_testEntities();
        public IQueryable<type_m_test> IQueryableType()
        {
            return db.type_m_test;
        }
        internal type_m_test Mapping(TypeModel m)
        {
            try
            {
                if (m != null)
                {
                    return new type_m_test()
                    {
                        TYPE_M_TEST_ID = m.TYPE_M_TEST_ID,
                        TYPE_M_TEST_NAME = m.TYPE_M_TEST_NAME,
                        TYPE_M_TEST_TIMESTMP = m.TYPE_M_TEST_TIMESTMP,
                        TYPE_M_TEST_ACTIVE = m.TYPE_M_TEST_ACTIVE
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal TypeModel Mapping(type_m_test m)
        {
            try
            {
                if (m != null)
                {
                    return new TypeModel()
                    {
                        TYPE_M_TEST_ID = m.TYPE_M_TEST_ID,
                        TYPE_M_TEST_NAME = m.TYPE_M_TEST_NAME,
                        //TYPE_M_TEST_TIMESTMP = m.TYPE_M_TEST_TIMESTMP,
                        TYPE_M_TEST_ACTIVE = m.TYPE_M_TEST_ACTIVE
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<type_m_test> Mapping(List<TypeModel> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<type_m_test> emList = new List<type_m_test>();
                    foreach (TypeModel m in list)
                    {
                        emList.Add(new type_m_test()
                        {
                            TYPE_M_TEST_ID = m.TYPE_M_TEST_ID,
                            TYPE_M_TEST_NAME = m.TYPE_M_TEST_NAME,
                            TYPE_M_TEST_TIMESTMP = m.TYPE_M_TEST_TIMESTMP,
                            TYPE_M_TEST_ACTIVE = m.TYPE_M_TEST_ACTIVE
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

        public List<TypeModel> Mapping(List<type_m_test> list)
        {
            try
            {
                if (list != null && list.Count > 0)
                {
                    List<TypeModel> emList = new List<TypeModel>();
                    foreach (type_m_test m in list)
                    {
                        emList.Add(new TypeModel()
                        {
                            TYPE_M_TEST_ID = m.TYPE_M_TEST_ID,
                            TYPE_M_TEST_NAME = m.TYPE_M_TEST_NAME,
                            //TYPE_M_TEST_TIMESTMP = m.TYPE_M_TEST_TIMESTMP,
                            TYPE_M_TEST_ACTIVE = m.TYPE_M_TEST_ACTIVE
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

        internal List<TypeModel> GetTypeList()
        {
            try
            {
                List<type_m_test> e = IQueryableType().ToList();
                List<TypeModel> eList = Mapping(e);
                return eList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
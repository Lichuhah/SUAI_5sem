using NHibernate;
using Pharmacy.Domain.Models;
using Pharmacy.Domain.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private NHibernateHelper helper;
        public BaseRepository()
        {
            helper = NHibernateHelper.GetInstance();
        }
        public List<T> All()
        {
            ISession session = helper.GetCurrentSession();
            try
            {
                var items = session.Query<T>().ToList();
                return items;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                helper.CloseSession();
            }

        }

        public T Get(int id)
        {
            ISession session = helper.GetCurrentSession();
            try
            {
                var item = session.Get<T>(id);
                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                helper.CloseSession();
            }
        }

        public T Add(T data)
        {
            ISession session = helper.GetCurrentSession();
            try
            {
                data.ID = (int)session.Save(data);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                helper.CloseSession();
            }
        }
        public T Update(T data)
        {
            ISession session = helper.GetCurrentSession();
            try
            {
                session.Update(data);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                helper.CloseSession();
            }
        }

        public bool Delete(T data)
        {
            ISession session = helper.GetCurrentSession();
            try
            {
                session.Delete(data);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                helper.CloseSession();
            }
        }
    }
}

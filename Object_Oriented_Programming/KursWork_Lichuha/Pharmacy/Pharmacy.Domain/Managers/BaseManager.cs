using Pharmacy.Domain.Models;
using Pharmacy.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Domain.Managers
{
    public class BaseManager<T> where T : BaseEntity
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        public List<T> All()
        {
            return repository.All();
        }

        public T Get(int id)
        {
            return repository.Get(id);
        }

        public T Add(T data)
        {
            return repository.Add(data);
        }

        public T Update(T data)
        {
            return repository.Update(data);
        }
    }
}

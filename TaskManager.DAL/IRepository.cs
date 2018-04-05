using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DAL
{
    public interface IRepository<T>
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}

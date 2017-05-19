using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_NET.Repositories
{
    interface IRepository<T>
    {
        void Add(T element);
        void Delete(T element);
        void SaveChanges();
    }
}


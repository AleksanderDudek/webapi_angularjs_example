using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_NET.Models;

namespace WebApi_NET.Repositories
{
    interface IParcelRepository : IRepository<Parcel>
    {
        IQueryable<Parcel> GetAllParcels();
    }
}



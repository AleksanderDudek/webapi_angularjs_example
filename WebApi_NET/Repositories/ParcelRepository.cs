using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_NET.Models;

namespace WebApi_NET.Repositories
{
    public class ParcelRepository : IParcelRepository
    {
        //private MobilePostServiceContext _db; 
        private MobilePostServiceContext _db;

        public ParcelRepository()
        {
            _db = new MobilePostServiceContext();
        }
        public IQueryable<Parcel> GetAllParcels()
        {
            return _db.Parcels;
        }
        public void Add(Parcel parcel)
        {
            _db.Parcels.Add(parcel);
        }
        public void Delete(Parcel parcel)
        {
            _db.Parcels.Remove(parcel);
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}


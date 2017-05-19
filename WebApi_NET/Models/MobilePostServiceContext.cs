using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_NET.Models
{
    public class MobilePostServiceContext : DbContext
    {
        public MobilePostServiceContext() : base("MobilePostService")
        { }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Postman> Postmen { get; set; }
    }
}


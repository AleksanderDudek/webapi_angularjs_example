using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_NET.Models;

namespace WebApi_NET.Repositories
{
    interface IPostmanRepository : IRepository<Postman>
    {
        Postman GetPostmanById(int id);
        Postman GetPostmanByUserId(int id);
        IQueryable<Postman> GetAllPostmen();
        //void EditPostman(Postman model);
        bool IsConfirmed(int id);
    }
}




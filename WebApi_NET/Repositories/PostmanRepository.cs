using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using WebApi_NET.Models;

namespace WebApi_NET.Repositories
{
    public class PostmanRepository : IPostmanRepository
    {
        private MobilePostServiceContext _db;
        public PostmanRepository()
        {
            _db = new MobilePostServiceContext();
        }
        public Postman GetPostmanById(int id)
        {
            return _db.Postmen.Find(id);
        }
        public Postman GetPostmanByUserId(int id)
        {
            return _db.Postmen.FirstOrDefault(postman => postman.UserId == id);
        }
        public bool IsConfirmed(int id)
        {
            return _db.Postmen.FirstOrDefault(u => u.UserId == id).IsConfirmed;
        }
        public void Add(Postman postman)
        {
            _db.Postmen.Add(postman);
        }
        public void Delete(Postman postman)
        {
            //simple membership provider

            //string name =
            //    ((SimpleMembershipProvider)Membership.Provider).GetUserNameFromId(postman.UserId);
            //_db.Postmen.Remove(postman);
            //_db.SaveChanges();
            //Roles.RemoveUserFromRole(name, "Postman");
            //((SimpleMembershipProvider)Membership.Provider).DeleteAccount(name);
            //((SimpleMembershipProvider)Membership.Provider).DeleteUser(name, true);
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public IQueryable<Postman> GetAllPostmen()
        {
            return _db.Postmen;
        }

        void EditPostman(Postman model)
        {

        }
    }
}

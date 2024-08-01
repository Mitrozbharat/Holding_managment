
using Holding_managment.Data;
using Holding_managment.Interface;
using System;
using System.Linq;

namespace Holding_management.Repository
{
    public class AuthRepository : IAuth
    {
        private readonly db_holdingContext _context;

        public AuthRepository(db_holdingContext holdingContext)
        {
            this._context = holdingContext;
        }

        public TblUser Login(string username, string password)
        {
            // Ideally, hash the incoming password and compare it with the stored hash
            var user = _context.TblUsers.FirstOrDefault(x => x.UserName == username && x.Password == password && x.IsDelete == 0);
            return user;
        }

        public TblUser GetUserById(int id)
        {
            // Example implementation, please customize it as needed
            return _context.TblUsers.FirstOrDefault(x => x.Id == id && x.IsDelete == 0);
        }
    }
}

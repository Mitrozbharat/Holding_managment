using Holding_managment.Models;
using Holding_managment.Data;

namespace Holding_managment.Interface
{
    public interface IAuth
    {
        public TblUser Login(string username,String password);
        public TblUser GetUserById(int id);
    }
}

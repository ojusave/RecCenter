using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LURecCenter.Entity;
using LURecCenter.DAL;

namespace LURecCenter.BAL
{
    public class UserBAL : IUserBAL
    {
        UserDAL _userdal;
        public UserBAL()
        {
            _userdal = new UserDAL();
        }
        public LoginResponse LoginUser(UserModel request)
        {
            return _userdal.LoginUser(request);
        }

        public listUserType GetUserTypes()
        {
            return _userdal.GetUserTypes();
        }


        public ListPerson GetUsers()
        {
            return _userdal.GetUsers();
        }


        public ResponseModel DeleteUser(int userid)
        {
            return _userdal.DeleteUser(userid);
        }


        public ResponseModel UpdateUser(PersonModel request)
        {
            return _userdal.UpdateUser(request);
        }
    }
}

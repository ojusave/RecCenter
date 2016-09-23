using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LURecCenter.Entity;

namespace LURecCenter.BAL
{
   public interface IUserBAL
    {
       LoginResponse LoginUser(UserModel request);
       listUserType GetUserTypes();
        ListPerson GetUsers();

        ResponseModel DeleteUser(int userid);

        ResponseModel UpdateUser(PersonModel request);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LURecCenter.Entity
{
   public class UserModel
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string  UserPassword { get; set; }
    }

   public class UserTypes
   {
       public int UserTypeId { get; set; }

       public string Type { get; set; }
      
   }

   public class listUserType : List<UserTypes>
    {

    }


}

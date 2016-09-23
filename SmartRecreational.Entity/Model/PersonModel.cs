using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LURecCenter.Entity
{
    public class PersonModel
    {
        public string firstname { get; set; }
        public string fullname { get; set; }
        public string lastname { get; set; }
        public DateTime? dateofbirth { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string pincode { get; set; }
        public string phone { get; set; }
        public string emailid { get; set; }
        public int? roleID { get; set; }
        public int? userID { get; set; }
        public int? personID { get; set; }
        public string IdNumber { get; set; }
        public string SessionId { get; set; }
        public string LoginTime { get; set; }
        public string LoginDate { get; set; }
        public string LoggedOutdate { get; set; }
        public string LoggedOuttime { get; set; }
     

    }

    public class ListPerson : List<PersonModel>
    { }
}

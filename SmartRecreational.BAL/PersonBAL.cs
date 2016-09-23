using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LURecCenter.Entity;
using LURecCenter.DAL;

namespace LURecCenter.BAL
{
    public class PersonBAL : IPersonBAL
    {
        PersonDAL _persondal;
        public PersonBAL()
        {
            _persondal = new PersonDAL();
        }
        public ResponseModel AddPerson(PersonModel request)
        {
            return _persondal.AddPerson(request);
        }
        public PersonModel GetPersonByIdNumber(string IdNumber)
        {
            return _persondal.GetPersonByIdNumber(IdNumber);
        }

        public PersonModel GetPersonById(int Userid)
        {
            return _persondal.GetPersonById(Userid);
        }

        public ListPerson GetPersonLoggedinHisbyId(int Userid)
        {
            return _persondal.GetPersonLoggedinHisbyId(Userid);
        }


        public listWritesUp GetwritesUp()
        {
            return _persondal.GetwritesUp();
        }
    }
}

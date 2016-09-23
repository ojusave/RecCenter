using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LURecCenter.Entity;

namespace LURecCenter.BAL
{
    public interface IPersonBAL
    {
        ResponseModel AddPerson(PersonModel request);
        PersonModel GetPersonById(int Userid);
        PersonModel GetPersonByIdNumber(string IdNumber);
        ListPerson GetPersonLoggedinHisbyId(int Userid);
        listWritesUp GetwritesUp();
    }
}

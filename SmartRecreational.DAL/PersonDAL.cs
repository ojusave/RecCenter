using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LURecCenter.Entity;
using LURecCenter.DAL.DataRepo;
using System.Data.Entity.Core.Objects;

namespace LURecCenter.DAL
{
    public class PersonDAL
    {
        public static LURecCenterEntities ObjContecxt;
        public PersonDAL()
        {
            ObjContecxt = new LURecCenterEntities();
        }
        public ResponseModel AddPerson(PersonModel request)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                ObjectParameter messagecode = new ObjectParameter("Messagecode", typeof(int));
                ObjectParameter message = new ObjectParameter("Message", typeof(string));
                int result = ObjContecxt.SpInsertUser(request.firstname, request.lastname, request.dateofbirth, request.userName, request.password, request.address, request.pincode, request.phone, request.emailid, request.roleID, request.IdNumber, messagecode, message);

                if (Convert.ToInt32(messagecode.Value) == 0)
                {
                    response.Message = "User Added Successfully";
                    response.MessageCode = ResponseMessageCode.SUCCESS;
                }
                else
                {
                    response.Message = message.Value.ToString();
                    response.MessageCode = ResponseMessageCode.FAIL;
                }

            }
            catch (Exception ex)
            {
                response.Message = "Error while inserting Purchase Payment stream";
                response.MessageCode = ResponseMessageCode.FAIL;
            }
            return response;
        }


        public PersonModel GetPersonById(int Userid)
        {
            PersonModel respo = new PersonModel();
            var query = (from us in ObjContecxt.TblUsers
                         join ps in ObjContecxt.TblPersons on us.PersonID equals ps.PersonId
                         where us.UserId == Userid
                         select new
                         {
                             us.UserName,
                             us.Email,
                             us.Phone,
                             ps.PostalCode,
                             ps.FirstName,
                             ps.LastName,
                             ps.Address,
                             ps.DOB,
                             ps.PersonId
                         }
                             ).FirstOrDefault();
            if (query != null)
            {
                respo.address = query.Address;
                respo.personID = query.PersonId;
                respo.firstname = query.FirstName;
                respo.lastname = query.LastName;
                respo.phone = query.Phone;
                respo.dateofbirth = query.DOB;
                respo.emailid = query.Email;
                respo.pincode = query.PostalCode;
                respo.userName = query.UserName;
            }
            return respo;
        }

        public ListPerson GetPersonLoggedinHisbyId(int Userid)
        {
            ListPerson list = new ListPerson();
            PersonModel respo = new PersonModel();
            var query = (from us in ObjContecxt.TblUsers
                         join ps in ObjContecxt.TblPersons on us.PersonID equals ps.PersonId
                         join lo in ObjContecxt.TblLoggedInUsers on us.UserId equals lo.Userid
                         where lo.Userid == Userid
                         select new
                         {
                             us.UserName,
                             us.Email,
                             us.Phone,
                             ps.PostalCode,
                             ps.FirstName,
                             ps.LastName,
                             ps.Address,
                             ps.DOB,
                             ps.PersonId,
                             lo.SessionId,
                             lo.LoginTime,
                             lo.LoginDate,
                             lo.LoggedOutdate,
                             lo.LoggedOuttime
                         }
                             );
           if (query != null)
            {
                foreach (var item in query)
                {
                    respo.SessionId = item.SessionId.ToString();
                    respo.address = item.Address;
                    respo.personID = item.PersonId;
                    respo.firstname = item.FirstName;
                    respo.lastname = item.LastName;
                    respo.fullname = item.FirstName + " " + item.LastName;
                    respo.phone = item.Phone;
                    respo.dateofbirth = item.DOB;
                    respo.emailid = item.Email;
                    respo.pincode = item.PostalCode;
                    respo.userName = item.UserName;
                    respo.LoggedOutdate = item.LoggedOutdate.ToString();
                    respo.LoggedOuttime = item.LoggedOuttime.ToString();
                    respo.LoginDate = item.LoginDate.ToString();
                    respo.LoginTime = item.LoginTime.ToString();
                }
                list.Add(respo);
            }
            return list;
        }

        public listWritesUp GetwritesUp()
        {
            listWritesUp list = new listWritesUp();
            var quwery = from writes in ObjContecxt.TblWritesUps
                         select writes;
            foreach (var item in quwery)
            {
                WritesUpModel write = new WritesUpModel()
                {
                    WritesUpid = item.WritesupID,
                    WritesUpText = item.WritesUpText
                };
                list.Add(write);
            }

            return list;
        }

        public PersonModel GetPersonByIdNumber(string IdNumber)
        {
            PersonModel respo = new PersonModel();
            var query = (from us in ObjContecxt.TblUsers
                         join ps in ObjContecxt.TblPersons on us.PersonID equals ps.PersonId
                         where ps.IdNumber == IdNumber
                         select new
                         {
                             us.UserName,
                             us.Email,
                             us.Phone,
                             ps.PostalCode,
                             ps.FirstName,
                             ps.LastName,
                             ps.Address,
                             ps.DOB,
                             ps.PersonId,
                             us.UserId,
                         }
                             ).FirstOrDefault();
            if (query != null)
            {
                respo.userID = query.UserId;
                respo.address = query.Address;
                respo.personID = query.PersonId;
                respo.firstname = query.FirstName;
                respo.lastname = query.LastName;
                respo.phone = query.Phone;
                respo.dateofbirth = query.DOB;
                respo.emailid = query.Email;
                respo.pincode = query.PostalCode;
                respo.userName = query.UserName;
            }
            InsertHistory(respo);
            return respo;
        }

        private ResponseModel InsertHistory(PersonModel person)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                TblLoggedInUser Loggedin = new TblLoggedInUser()
                {
                    Userid = person.userID,
                    UserName = person.userName,
                    LoginDate = DateTime.UtcNow,
                    LoginTime = DateTime.UtcNow.TimeOfDay,
                };
                ObjContecxt.TblLoggedInUsers.Add(Loggedin);
                ObjContecxt.SaveChanges();

                response.MessageCode = ResponseMessageCode.SUCCESS;
                response.Message = "SUCESSS";
            }

            catch (Exception ex)
            {
                response.MessageCode = ResponseMessageCode.FAIL;
                response.Message = "Error occour";
            }
            return response;
        }
    }
}

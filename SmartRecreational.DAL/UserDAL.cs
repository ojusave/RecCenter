using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LURecCenter.Entity;
using LURecCenter.DAL.DataRepo;

namespace LURecCenter.DAL
{
    public class UserDAL
    {
        public static LURecCenterEntities ObjContecxt;
        public UserDAL()
        {
            ObjContecxt = new LURecCenterEntities();
        }

        public LoginResponse LoginUser(UserModel request)
        {
            LoginResponse response;
            {
                var query = (from logindata in ObjContecxt.TblUsers select logindata).Where(p => p.UserName == request.UserName && p.Password == request.UserPassword);

                if (query.Count() != 0)
                {
                    response = new LoginResponse()
                    {
                        UserRole = query.FirstOrDefault().RoleID.ToString(),
                        UserId = query.FirstOrDefault().UserId.ToString(),
                        UserName = query.FirstOrDefault().UserName.ToString(),
                        Message = "LOGIN SUCCESFULL",
                        MessageCode = ResponseMessageCode.SUCCESS
                    };
                }
                else
                {
                    response = new LoginResponse()
                    {
                        Message = "LOGIN FAILED",
                        MessageCode = ResponseMessageCode.FAIL
                    };
                }

            }
            return response;
        }

        public listUserType GetUserTypes()
        {
            listUserType list = new listUserType();
            var query = from UserTyp in ObjContecxt.TblmstrUserTypes
                         select UserTyp;
            foreach (var item in query)
            {
                UserTypes uty = new UserTypes()
                {
                    Type = item.TypeName,
                    UserTypeId = item.TypeID
                };
                list.Add(uty);
            }
            return list;

        }


        public ListPerson GetUsers()
        {
            ListPerson list = new ListPerson();
            var quwery = (from User in ObjContecxt.TblUsers
                          join per in ObjContecxt.TblPersons on User.PersonID equals per.PersonId
                          orderby per.PersonId
                          select new
                          {
                              User.UserId,
                              User.UserName,
                              per.FirstName,
                              per.LastName,
                              per.PersonId,
                              per.Email,
                              per.DOB,
                              per.Address,
                              User.Phone
                          }).ToList();
            foreach (var item in quwery)
            {
                PersonModel per = new PersonModel()
                {
                    userName = item.UserName,
                    phone = item.Phone,
                    personID = item.PersonId,
                    userID = item.UserId,
                    emailid = item.Email,
                    firstname = item.FirstName,
                    lastname = item.LastName,
                    address = item.Address,
                    dateofbirth = item.DOB,
                    fullname = item.FirstName + " " + item.LastName
                };
                list.Add(per);
            }

            return list;

        }


        public ResponseModel DeleteUser(int userid)
        {
            ResponseModel resp = new ResponseModel();
            try
            {
                TblUser user = (from c in ObjContecxt.TblUsers
                                where c.UserId == userid
                                select c).FirstOrDefault();
                ObjContecxt.TblUsers.Remove(user);
                ObjContecxt.SaveChanges();
                resp.MessageCode = ResponseMessageCode.SUCCESS;
            }
            catch (Exception ex)
            {
                resp.MessageCode = ResponseMessageCode.FAIL;

            }
            return resp;
        }

        public ResponseModel UpdateUser(PersonModel request)
        {
            ResponseModel resp = new ResponseModel();
            try
            {
                TblUser user = (from c in ObjContecxt.TblUsers
                                where c.UserId == request.userID
                                select c).FirstOrDefault();
                user.Phone = request.phone;
                user.Email = request.emailid;
                ObjContecxt.SaveChanges();

                TblPerson person = (from c in ObjContecxt.TblPersons
                                    where c.PersonId == request.personID
                                    select c).FirstOrDefault();
                person.FirstName = request.firstname;
                person.LastName = request.lastname;
                person.PostalCode = request.pincode;
                person.Address = request.address;
                person.Email = request.emailid;
                ObjContecxt.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return resp;

        }
    }
}

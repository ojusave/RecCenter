using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LURecCenter.Entity;
using LURecCenter.DAL.DataRepo;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;

namespace LURecCenter.DAL
{
    public class UtilityDAL
    {
        public static LURecCenterEntities ObjContecxt;

        public UtilityDAL()
        {
            ObjContecxt = new LURecCenterEntities();
        }

        public ResponseModel insertEquipment(EquipmentModel request)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                tblEquipment equipment = new tblEquipment()
                {
                    EquipmentName = request.EquipmentName,
                    EquipmentAddDate = request.EquipmentAddDate,
                    EquipmentBrand = request.EquipmentBrand,
                    EquipmentBARCode = request.EquipmentBARCode,
                    EquipmentPrice = Convert.ToDecimal(request.EquipmentPrice),
                    CreatedBy = 1,
                    IsActive = true

                };
                ObjContecxt.tblEquipments.Add(equipment);
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

        public EquipmentList GetEquipment()
        {
            EquipmentList list = new EquipmentList();
            var quwery = from Equipments in ObjContecxt.tblEquipments
                         select Equipments;
            foreach (var item in quwery)
            {
                EquipmentModel equipment = new EquipmentModel()
                {
                    EquipmentID = item.EquipmentID,
                    EquipmentPrice = item.EquipmentPrice.ToString(),
                    EquipmentBARCode = item.EquipmentBARCode,
                    EquipmentName = item.EquipmentName,
                    EquipmentBrand = item.EquipmentBrand,
                };
                list.Add(equipment);
            }

            return list;
        }


        public listShift GetActiveShift()
        {
            listShift list = new listShift();
            var quwery = from wrty in ObjContecxt.TblShifts
                         where wrty.Avilable == true & wrty.ShiftDate > DateTime.UtcNow
                         select wrty;
            foreach (var item in quwery)
            {
                ShiftModel wrt = new ShiftModel()
                {
                    ShiftId = item.ShiftId,
                    ShiftName = item.ShiftName,
                    ShiftDate = item.ShiftDate,
                    shiftto = item.Shiftto,
                    ShiftFrom = item.Shiftfrom,
                    ShiftComment = item.ShiftComment
                };
                list.Add(wrt);
            }

            return list;
        }

        public ResponseModel PickedShiftUpdate(ShiftModel request)
        {
            ResponseModel respo = new ResponseModel();
            try
            {
                TblShift shft = (from c in ObjContecxt.TblShifts
                                 where c.ShiftId == request.ShiftId
                                 select c).FirstOrDefault();
                shft.PickedByUser = null;
                shft.PickedOn = null;
                shft.Avilable = true;

                ObjContecxt.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return respo;
        }

        public listShift GetPickedshift(int userid)
        {
            listShift list = new listShift();
            var quwery = from wrty in ObjContecxt.TblShifts
                         where wrty.PickedByUser == userid & wrty.Avilable == false & wrty.ShiftDate > DateTime.UtcNow
                         select wrty;
            foreach (var item in quwery)
            {
                ShiftModel wrt = new ShiftModel()
                {
                    ShiftId = item.ShiftId,
                    ShiftName = item.ShiftName,
                    ShiftDate = item.ShiftDate,
                    shiftto = item.Shiftto,
                    ShiftFrom = item.Shiftfrom,
                    ShiftComment = item.ShiftComment
                };
                list.Add(wrt);
            }

            return list;
        }

        public ResponseModel DeleteEquipment(int equipmentid)
        {
            ResponseModel respo = new ResponseModel();
            try
            {
                tblEquipment equpment = (from c in ObjContecxt.tblEquipments
                                         where c.EquipmentID == equipmentid
                                         select c).FirstOrDefault();
                ObjContecxt.tblEquipments.Remove(equpment);
                ObjContecxt.SaveChanges();
                respo.MessageCode = ResponseMessageCode.SUCCESS;
            }
            catch (Exception ex)
            {
                respo.MessageCode = ResponseMessageCode.FAIL;

            }
            return respo;
        }

        public ResponseModel PickShiftUpdate(ShiftModel request)
        {
            ResponseModel respo = new ResponseModel();
            try
            {
                TblShift shft = (from c in ObjContecxt.TblShifts
                                 where c.ShiftId == request.ShiftId
                                 select c).FirstOrDefault();
                shft.PickedByUser = request.PickedByUser;
                shft.PickedOn = DateTime.UtcNow;
                shft.Avilable = false;

                ObjContecxt.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return respo;
        }

        public ResponseModel UpdateEquipment(EquipmentModel request)
        {
            ResponseModel respo = new ResponseModel();
            try
            {
                tblEquipment equi = (from c in ObjContecxt.tblEquipments
                                     where c.EquipmentID == request.EquipmentID
                                     select c).FirstOrDefault();
                equi.EquipmentName = request.EquipmentName;
                equi.EquipmentPrice = Convert.ToDecimal(request.EquipmentPrice);
                equi.EquipmentBrand = request.EquipmentBrand;
                equi.EquipmentBARCode = request.EquipmentBARCode;
                ObjContecxt.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return respo;
        }

        public ResponseModel IssueEquipment(IssueEquipment equipment)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                TblIssuedEquipment equipm = new TblIssuedEquipment()
                {
                    EquipmentID = equipment.EquipmentId,
                    UserID = equipment.UserId,
                    IssueComments = equipment.issueComments,
                    IsReturn = equipment.isRerurned,
                    IssueOn = DateTime.UtcNow,

                };
                ObjContecxt.TblIssuedEquipments.Add(equipm);
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

        public IssuedEquipmentsList GetIssuedEquipments()
        {
            IssuedEquipmentsList list = new IssuedEquipmentsList();
            ObjectParameter messagecode = new ObjectParameter("Messagecode", typeof(int));
            ObjectParameter message = new ObjectParameter("Message", typeof(string));
            var quwery = from Equipments in ObjContecxt.SpGetIssuedequipment(message, messagecode)
                         select Equipments;
            foreach (var item in quwery)
            {
                IssuedEquipments equipment = new IssuedEquipments()
                {
                    IssueEqipmentId = item.IssueID,

                    EquipmentBARCode = item.EquipmentBARCode,
                    EquipmentName = item.EquipmentName,
                    EquipmentBrand = item.EquipmentBrand,
                    IssueOn = item.IssueOn,
                    mailID = item.mailID,
                    PersonFullName = item.PersonFullName,
                    IssueComments = item.IssueComments
                };
                list.Add(equipment);
            }

            return list;
        }


        public ResponseModel ReturnEquipment(IssuedEquipments request)
        {
            ResponseModel respo = new ResponseModel();
            try
            {
                TblIssuedEquipment equi = (from c in ObjContecxt.TblIssuedEquipments
                                           where c.IssueID == request.IssueEqipmentId
                                           select c).FirstOrDefault();
                equi.IsReturn = true;
                equi.ReturnOn = DateTime.UtcNow;
                ObjContecxt.SaveChanges();
                respo.MessageCode = ResponseMessageCode.SUCCESS;
            }
            catch (Exception ex)
            {
                respo.MessageCode = ResponseMessageCode.FAIL;
            }
            return respo;
        }

        public ResponseModel createShift(ShiftModel request)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                TblShift shift = new TblShift()
                {
                    Shiftfrom = request.ShiftFrom,
                    Shiftto = request.shiftto,
                    ShiftDate = request.ShiftDate,
                    ShiftName = request.ShiftName,
                    ShiftComment = request.ShiftComment,

                    CreatedBy = 1,
                    Avilable = true

                };
                ObjContecxt.TblShifts.Add(shift);
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

        public ResponseModel createWriteSup(WritesUpModel request)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                TblWritesUp shift = new TblWritesUp()
                {
                    CreatedOn = DateTime.UtcNow,
                    WritesUpText = request.WritesUpText,
                    CreatedBy = 1,
                    IsActive = true,
                    TOUser = request.touser

                };
                ObjContecxt.TblWritesUps.Add(shift);
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
       /* public ResponseModel RequestEquipment(RequestEquipmentModel request)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                TblRequestedEquipment shift = new TblRequestedEquipment()
                {
                    CreatedOn = DateTime.UtcNow,
                    WritesUpText = request.WritesUpText,
                    CreatedBy = 1,
                    IsActive = true,
                    TOUser = request.touser

                };
                ObjContecxt.TblRequestedEquipment.Add(shift);
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
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LURecCenter.BAL.Interface;
using LURecCenter.Entity;
using LURecCenter.DAL;
using System.Data;
namespace LURecCenter.BAL
{
  public  class UtilityBAL : IUtilityBAL
    {
        public ResponseModel insertEquipment(EquipmentModel request)
        {
            UtilityDAL _dal = new UtilityDAL();
          return  _dal.insertEquipment(request);
        }

        public EquipmentList GetEquipment()
        {
            UtilityDAL _dal = new UtilityDAL();
            return _dal.GetEquipment();
        }

       public ResponseModel DeleteEquipment(int equipmentid)
        {
            UtilityDAL _dal = new UtilityDAL();
            return _dal.DeleteEquipment(equipmentid);
        }


       public ResponseModel UpdateEquipment(EquipmentModel request)
       {
           UtilityDAL _dal = new UtilityDAL();
           return _dal.UpdateEquipment(request);
       }


       public ResponseModel IssueEquipment(IssueEquipment equipment)
       {
           UtilityDAL _dal = new UtilityDAL();
           return _dal.IssueEquipment(equipment);
       }


       public IssuedEquipmentsList GetIssuedEquipments()
       {
           UtilityDAL _dal = new UtilityDAL();
           return _dal.GetIssuedEquipments();
       }

       public ResponseModel PickShiftUpdate(ShiftModel request)
       {
           UtilityDAL _dal = new UtilityDAL();
           return _dal.PickShiftUpdate(request);
       }
       public ResponseModel ReturnEquipment(IssuedEquipments request)
       {
           UtilityDAL _dal = new UtilityDAL();
           return _dal.ReturnEquipment(request);
       }
       public ResponseModel createShift(ShiftModel request)
       {
           UtilityDAL _dal = new UtilityDAL();
           return _dal.createShift(request);
       }

       public listShift GetActiveShift()
       {
           UtilityDAL _dal = new UtilityDAL();
           return _dal.GetActiveShift();
       }

       public ResponseModel createWriteSup(WritesUpModel request)
       {
           UtilityDAL _dal = new UtilityDAL();
           return _dal.createWriteSup(request);
       }
        /*
        public listShift GetPickedshift(int userid)
        {
            throw new NotImplementedException();
        }

        public ResponseModel PickedShiftUpdate(ShiftModel request)
        {
            throw new NotImplementedException();
        }*/

        public ResponseModel RequestEquipment(RequestEquipmentModel request)
        {
            throw new NotImplementedException();
        }
        
       /* *  public ResponseModel RequestEquipment(RequestEquipmentModel request)
          {
              UtilityDAL _dal = new UtilityDAL();
              return _dal.RequestEquipment(request);
          }
*/
          public listShift GetPickedshift(int userid)
         {
             UtilityDAL _dal = new UtilityDAL();
             return _dal.GetPickedshift(userid);
         }


         public ResponseModel PickedShiftUpdate(ShiftModel request)
         {
             UtilityDAL _dal = new UtilityDAL();
             return _dal.PickedShiftUpdate(request);
         }
    }
}

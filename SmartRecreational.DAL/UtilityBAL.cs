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


       public ResponseModel ReturnEquipment(IssuedEquipments request)
       {
           UtilityDAL _dal = new UtilityDAL();
           return _dal.ReturnEquipment(request);
       }
    }
}

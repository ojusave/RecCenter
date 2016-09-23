using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LURecCenter.Entity;


namespace LURecCenter.BAL.Interface
{
    public interface IUtilityBAL
    {
        ResponseModel insertEquipment(EquipmentModel request);
        ResponseModel UpdateEquipment(EquipmentModel request);
        EquipmentList GetEquipment();
        ResponseModel DeleteEquipment(int equipmentid);
        ResponseModel IssueEquipment(IssueEquipment equipment);
        ResponseModel ReturnEquipment(IssuedEquipments request);
        IssuedEquipmentsList GetIssuedEquipments();
        listShift GetActiveShift();
        listShift GetPickedshift(int userid);
        ResponseModel PickShiftUpdate(ShiftModel request);
        ResponseModel PickedShiftUpdate(ShiftModel request);
        ResponseModel createShift(ShiftModel request);
        ResponseModel createWriteSup(WritesUpModel request);
        ResponseModel RequestEquipment(RequestEquipmentModel request);
    }
}

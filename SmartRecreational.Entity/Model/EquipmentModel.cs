using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LURecCenter.Entity
{
    public class EquipmentModel
    {
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentBARCode { get; set; }
        public string EquipmentType { get; set; }
        public DateTime? EquipmentAddDate { get; set; }
        public string EquipmentUserCount { get; set; }
        public string EquipmentPrice { get; set; }
        public string EquipmentBrand { get; set; }
    }

    public class EquipmentList : List<EquipmentModel> { }
}

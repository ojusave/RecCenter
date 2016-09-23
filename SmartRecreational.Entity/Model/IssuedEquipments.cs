using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LURecCenter.Entity
{
   public class IssuedEquipments
    {
        public int IssueEqipmentId { get; set; }

        public string  EquipmentName { get; set; }

        public string EquipmentBARCode { get; set; }

        public DateTime? IssueOn { get; set; }

        public string mailID { get; set; }

        public string PersonFullName { get; set; }
        public string EquipmentBrand { get; set; }

       
        public string IssueComments { get; set; }

       
    }

   public class IssuedEquipmentsList : List<IssuedEquipments> { }
}

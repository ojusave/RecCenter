using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LURecCenter.Entity
{
   public class IssueEquipment
    {
        public int EquipmentId { get; set; }
        public int UserId { get; set; }
        public string issueComments { get; set; }
        public string retComments { get; set; }
        public bool isRerurned { get; set; }
    }
}

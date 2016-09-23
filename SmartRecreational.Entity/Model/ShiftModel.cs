using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LURecCenter.Entity
{
    public class ShiftModel
    {
        public long ShiftId { get; set; }
        public string ShiftName { get; set; }
        public string ShiftComment { get; set; }
        public DateTime? ShiftDate { get; set; }
        public string ShiftFrom { get; set; }
        public string shiftto { get; set; }
        public bool Avilable { get; set; }
        public int PickedByUser { get; set; }
        public DateTime PickedOn { get; set; }
        public int CreatedBy { get; set; }


    }

    public class listShift : List<ShiftModel>
    {

    }
}

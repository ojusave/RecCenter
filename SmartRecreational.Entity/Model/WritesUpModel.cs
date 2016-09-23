using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LURecCenter.Entity
{
    public class WritesUpModel
    {
        public int WritesUpid { get; set; }

        public string WritesUpText { get; set; }

        public string touser { get; set; }
    }
    public class listWritesUp : List<WritesUpModel>
    { }
}

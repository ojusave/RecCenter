using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LURecCenter.Entity
{
   public class RequestModel
    {
        public long? KeyId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string ActionName { get; set; }
    }
}

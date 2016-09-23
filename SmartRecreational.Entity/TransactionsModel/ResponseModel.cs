using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LURecCenter.Entity
{
    public class ResponseModel
    {
        public string Id { get; set; }

        public string Code { get; set; }

        public string Key { get; set; }

        public string Message { get; set; }

        public ResponseMessageCode MessageCode { get; set; }
    }

    public class LoginResponse
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserRole { get; set; }

        public string Message { get; set; }

        public ResponseMessageCode MessageCode { get; set; }
    }

    public enum ResponseMessageCode
    {
        FAIL = 1,
        SUCCESS = 0,
        DELETED = 2
    }
}

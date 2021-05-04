using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace anti_xss_middleware.Model
{
    public class ErrorResponse
    {
        public int ErrorCode { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Transishn.RequestModels
{
    public class RequestCarType
    {
        public string Type { get; set; }

        public RequestCarType(string type)
        {
            Type = type;
        }
    }
}

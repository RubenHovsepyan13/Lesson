using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Transishn.RequestModels
{
    public class RequestCrashCars
    {
        public bool CarCrash { get; set; }

        public RequestCrashCars(bool carCrash)
        {
            CarCrash = carCrash;
        }
    }
}

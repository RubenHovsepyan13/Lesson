using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Transishn.RequestModels
{
    public class RequesCantainer
    {
        public bool Open { get; set; }

        public RequesCantainer(bool open)
        {
            Open = open;
        }
    }
}

using MyC_49.Transishn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Repository
{
    public class LogisticModels
    {
        public LogisticModels(string type, bool carCrash, bool open, string from, string to)
        {
            Type = type;
            CarCrash = carCrash;
            Open = open;
            From = from;
            To = to;
        }

        public string Type { get; set; }
        public bool CarCrash { get; set; }
        public bool Open {  get; set; }
        public string From { get; set; }
        public string To { get; set; }

    }
}

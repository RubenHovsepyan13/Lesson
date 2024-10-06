using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Transishn
{
    public class CarType
    {
        public CarType()
        {
        }

        public CarType(int id, string type, decimal caficent)
        {
            Id = id;
            Type = type;
            Caficent = caficent;
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Caficent { get; set; }

    }
}

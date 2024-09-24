using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Transishn
{
    internal class CrashedCar
    {
        public CrashedCar()
        {
        }

        public CrashedCar(int id, bool carCrash, decimal caficent)
        {
            Id = id;
            CarCrash = carCrash;
            Caficent = caficent;
        }

        public int Id { get; set; }
        public bool CarCrash {  get; set; }
        public decimal Caficent { get; set; }

    }
}

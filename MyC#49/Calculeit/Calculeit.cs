using MyC_49.Transishn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Calculeit
{
    public class Calculeit
    {
        public Calculeit(CarType carType, CrashedCar crashedCar, Direction direction, Cantainer cantainer)
        {
            CarType = carType;
            CrashedCar = crashedCar;
            Direction = direction;
            Cantainer = cantainer;
        }

        public CarType CarType { get; set; }
        public CrashedCar CrashedCar { get; set; }
        public Direction Direction { get; set; }
        public Cantainer Cantainer { get; set; }

    }
}

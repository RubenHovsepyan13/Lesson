using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Calculeit
{
    public interface ICalculeit
    {
        decimal Calculeitm(Calculeit calculeit);
        decimal Calculeitm(CalculeitModels calculeitModels);
    }
    public class CalculeitServer : ICalculeit
    {
        public decimal Calculeitm(Calculeit calculeit)
        {
            if (calculeit.Direction.Price != 0)
            {
                return calculeit.Direction.Price * calculeit.Cantainer.Caficent * calculeit.CarType.Caficent * calculeit.CrashedCar.Caficent;
            }
            else
            {
                return calculeit.Direction.Km * 100 * calculeit.Cantainer.Caficent * calculeit.CarType.Caficent * calculeit.CrashedCar.Caficent;
            }
        }
    }
}

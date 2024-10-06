using MyC_49.Calculeit;
using MyC_49.Irepasiroti;
using MyC_49.Repository;
using MyC_49.Transishn;
using MyC_49.Transishn.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Logistic
{
    public interface ILogistic
    {
        decimal GetPrice(LogisticModels logisticModels);
    }
    public class LogisticServis : ILogistic
    {
        private readonly IRepasitori<CarType, RequestCarType> _carTypeRepasitori;
        private readonly IRepasitori<CrashedCar, RequestCrashCars> _crashCarRepasitori;
        private readonly IRepasitori<Direction, RequestDirection> _directorRepasitori;
        private readonly IRepasitori<Cantainer, RequesCantainer> _canteinetrepasitori;
        private readonly ICalculeit _calculeitServise;

        public LogisticServis(IRepasitori<CarType, RequestCarType> carTypeRepasitori, IRepasitori<CrashedCar, RequestCrashCars> crashCarRepasitori, IRepasitori<Direction, RequestDirection> directorRepasitori, IRepasitori<Cantainer, RequesCantainer> canteinetrepasitori, ICalculeit calculeitServise)
        {
            _carTypeRepasitori = carTypeRepasitori;
            _crashCarRepasitori = crashCarRepasitori;
            _directorRepasitori = directorRepasitori;
            _canteinetrepasitori = canteinetrepasitori;
            _calculeitServise = calculeitServise;
        }

        public decimal GetPrice(LogisticModels logisticModels)
        {
            var carType = _carTypeRepasitori.Find(new RequestCarType(logisticModels.Type));
            var crashCar = _crashCarRepasitori.Find(new RequestCrashCars(logisticModels.CarCrash));
            var directori = _directorRepasitori.Find(new RequestDirection(logisticModels.From, logisticModels.To));
            var conteiner = _canteinetrepasitori.Find(new RequesCantainer(logisticModels.Open));

            return _calculeitServise.Calculeitm(new CalculeitModels(carType, crashCar, directori, conteiner));
        }
    }
}

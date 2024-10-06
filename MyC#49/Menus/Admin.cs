using MyC_49.Irepasiroti;
using MyC_49.IStart;
using MyC_49.Repository;
using MyC_49.Transishn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Menus
{
    internal class Admin : Menu
    {
        public override void Start()
        {
            IRepasitori<CarType> repasitoriCarType = new RepasitoriCarType();
            IRepasitori<CrashedCar> repasitoriCarCrash = new RepasitoriCarCrash();
            IRepasitori<Cantainer> repasitoriConteiner = new RepasitoriConteiner();
            IRepasitori<Direction> repasitoriDirection = new RepasitoriDirection();

            while (true)
            {
                Console.WriteLine("Choos");
                Console.WriteLine("Car Type: 1 || Car Crash: 2 || Conteiner: 3 || Direction: 4 || Exit: 0");
                string choosAdmin = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(choosAdmin))
                {
                    Console.WriteLine("Error");
                    continue;
                }
                int point;
                if (!int.TryParse(choosAdmin, out point))
                {
                    Console.WriteLine("Error");
                    continue;
                }
                if (point == 0)
                {
                    Console.WriteLine("Exit");
                    break;
                }

                switch (point)
                {
                    case 1:
                        Console.WriteLine("Car Type");

                        while (true)
                        {

                            Console.WriteLine("Add: 1 || Update: 2 || Find By Id: 3 || Find All: 4 || Delete: 5 || Exit: 0");
                            string chooseCarType = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(chooseCarType))
                            {
                                Console.WriteLine("Error");
                                continue;
                            }
                            int point1;
                            if (!int.TryParse(chooseCarType, out point1))
                            {
                                Console.WriteLine("Error");
                                continue;
                            }
                            if (point1 == 0)
                            {
                                Console.WriteLine("Exit");
                                break;
                            }
                            switch (point1)
                            {
                                case 1:
                                    CarType carType = new CarType();
                                    Console.WriteLine("Add Car Type");
                                    Console.Write("Id: ");
                                    carType.Id = int.Parse(Console.ReadLine());
                                    Console.Write("Type: ");
                                    carType.Type = Console.ReadLine();
                                    Console.Write("Caficent: ");
                                    carType.Caficent = decimal.Parse(Console.ReadLine());
                                    repasitoriCarType.Addd(carType);
                                    break;
                                case 2:
                                    Console.WriteLine("Update Car Type");
                                    Console.WriteLine("Choose Id:");
                                    int carChoos = int.Parse(Console.ReadLine());
                                    var findCar = repasitoriCarType.GetById(carChoos);
                                    findCar.Id = carChoos;
                                    Console.Write("Type: ");
                                    findCar.Type = Console.ReadLine();
                                    Console.Write("Caficent: ");
                                    findCar.Caficent = decimal.Parse(Console.ReadLine());
                                    repasitoriCarType.Updatee(findCar);//-----------------------------------
                                    break;
                                case 3:
                                    Console.WriteLine("Find by Id");
                                    Console.WriteLine("Choose Id:");
                                    int carChoos1 = int.Parse(Console.ReadLine());
                                    var findcarr = repasitoriCarType.GetById(carChoos1);
                                    Console.Write("Id: ");
                                    Console.WriteLine(findcarr.Id);
                                    Console.Write("Type: ");
                                    Console.WriteLine(findcarr.Type);
                                    Console.Write("Caficent: ");
                                    Console.WriteLine(findcarr.Caficent);
                                    Console.WriteLine("---------------------");
                                    break;
                                case 4:
                                    Console.WriteLine("Find all");
                                    var allcars = repasitoriCarType.GetAll();
                                    foreach (var car in allcars)
                                    {
                                        Console.Write("Id: ");
                                        Console.WriteLine(car.Id);
                                        Console.Write("Type: ");
                                        Console.WriteLine(car.Type);
                                        Console.Write("Caficent: ");
                                        Console.WriteLine(car.Caficent);
                                        Console.WriteLine("---------------------");
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("Delete");
                                    Console.WriteLine("Choos Id");
                                    int chooos = int.Parse(Console.ReadLine());
                                    repasitoriCarType.Deletee(chooos);
                                    Console.WriteLine("Good job");
                                    break;
                                default:
                                    Console.WriteLine("Error");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("Car Crash");
                            Console.WriteLine("Add: 1 || Update: 2 || Find By Id: 3 || Find All: 4 || Delete: 5 || Exit: 0");
                            string chooseCarcrash = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(chooseCarcrash))
                            {
                                Console.WriteLine("Error");
                                continue;
                            }
                            int point2;
                            if (!int.TryParse(chooseCarcrash, out point2))
                            {
                                Console.WriteLine("Error");
                                continue;
                            }
                            if (point2 == 0)
                            {
                                Console.WriteLine("Exit");
                                break;
                            }
                            switch (point2)
                            {
                                case 1:
                                    CrashedCar crashedCar = new CrashedCar();
                                    Console.WriteLine("Add crash hed car");
                                    Console.Write("Id: ");
                                    crashedCar.Id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("CarCrash");
                                    Console.WriteLine("true or false");
                                    crashedCar.CarCrash = bool.Parse(Console.ReadLine());
                                    Console.Write("Caficent: ");
                                    crashedCar.Caficent = decimal.Parse(Console.ReadLine());
                                    repasitoriCarCrash.Addd(crashedCar);
                                    break;
                                case 2:
                                    Console.WriteLine("Update");
                                    break;
                                case 3:
                                    Console.WriteLine("Find by Id");
                                    Console.WriteLine("Choose Id");
                                    int crasid = int.Parse(Console.ReadLine());
                                    var findcrash = repasitoriCarCrash.GetById(crasid);
                                    Console.Write("Id: ");
                                    Console.WriteLine(findcrash.Id);
                                    Console.Write("Crash car: ");
                                    Console.WriteLine(findcrash.CarCrash);
                                    Console.Write("Caficent: ");
                                    Console.WriteLine(findcrash.Caficent);
                                    Console.WriteLine("----------------------");
                                    break;
                                case 4:
                                    Console.WriteLine("Find all");
                                    var allcras = repasitoriCarCrash.GetAll();
                                    foreach (var c in allcras)
                                    {
                                        Console.Write("Id: ");
                                        Console.WriteLine(c.Id);
                                        Console.Write("Crash car: ");
                                        Console.WriteLine(c.CarCrash);
                                        Console.Write("Caficent: ");
                                        Console.WriteLine(c.Caficent);
                                        Console.WriteLine("----------------------");
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("Delete");
                                    Console.WriteLine("Choose Id:");
                                    int delet = int.Parse(Console.ReadLine());
                                    repasitoriCarCrash.Deletee(delet);
                                    Console.WriteLine("Good job");
                                    break;
                                default:
                                    Console.WriteLine("Error");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("Conteiner");
                            Console.WriteLine("Add: 1 || Update: 2 || Find By Id: 3 || Find All: 4 || Delete: 5 || Exit: 0");
                            string chooseConteiner = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(chooseConteiner))
                            {
                                Console.WriteLine("Error");
                                continue;
                            }
                            int point3;
                            if (!int.TryParse(chooseConteiner, out point3))
                            {
                                Console.WriteLine("Error");
                                continue;
                            }
                            if (point3 == 0)
                            {
                                Console.WriteLine("Exit");
                                break;
                            }
                            switch (point3)
                            {
                                case 1:
                                    Console.WriteLine("Add");
                                    break;
                                case 2:
                                    Console.WriteLine("Update");
                                    break;
                                case 3:
                                    Console.WriteLine("Find by Id");
                                    break;
                                case 4:
                                    Console.WriteLine("Find all");
                                    break;
                                case 5:
                                    Console.WriteLine("delete");
                                    break;
                                default:
                                    Console.WriteLine("Error");
                                    break;

                            }
                        }
                        break;
                    case 4:
                        while (true)
                        {
                            Console.WriteLine("Direction");
                            Console.WriteLine("Add: 1 || Update: 2 || Find By Id: 3 || Find All: 4 || Delete: 5 || Exit: 0");
                            string chooseDirektion = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(chooseDirektion))
                            {
                                Console.WriteLine("Error");
                                continue;
                            }
                            int point4;
                            if (!int.TryParse(chooseDirektion, out point4))
                            {
                                Console.WriteLine("Error");
                                continue;
                            }
                            if (point4 == 0)
                            {
                                Console.WriteLine("Exit");
                                break;
                            }
                            switch (point4)
                            {
                                case 1:
                                    Console.WriteLine("Add");
                                    break;
                                case 2:
                                    Console.WriteLine("Update");
                                    break;
                                case 3:
                                    Console.WriteLine("Find by Id");
                                    break;
                                case 4:
                                    Console.WriteLine("Find all");
                                    break;
                                case 5:
                                    Console.WriteLine("delete");
                                    break;
                                default:
                                    Console.WriteLine("Error");
                                    break;
                            }
                        }
                        break;
                }
            }

        }
    }
}

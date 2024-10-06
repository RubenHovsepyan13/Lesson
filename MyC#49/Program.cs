using MyC_49.IStart;
using MyC_49.Menus;
using MyC_49.Repository;
using MyC_49.Transishn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu menu = null;
                Console.WriteLine("User: 1 || Admin: 2 || Exit: 0");
                string choos = Console.ReadLine();

                if (string.IsNullOrEmpty(choos))
                {
                    Console.WriteLine("Error");
                    continue;
                }
                int point;
                if (!int.TryParse(choos, out point))
                {
                    Console.WriteLine("Error");
                    continue;
                }
                if (point == 0)
                {
                    Console.WriteLine("Exit");
                    return;
                }
                switch (point)
                {
                    case 1:
                        menu = new User();
                        break;
                    case 2:
                        menu = new Admin();
                        break;
                    default:
                        Console.WriteLine("Tray agan");
                        break;
                }
                menu.Start();
            }
        }
    }
}

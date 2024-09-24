using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Transishn
{
    internal class Direction
    {
        public Direction(int id, string from, string to, int km, decimal price, decimal caficent)
        {
            Id = id;
            From = from;
            To = to;
            Km = km;
            Price = price;
            Caficent = caficent;
        }

        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Km { get; set; }
        public decimal Price { get; set; }
        public decimal Caficent { get; set; }
    }
}

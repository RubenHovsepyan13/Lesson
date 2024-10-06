using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Transishn
{
    public class Direction
    {
        public Direction()
        {
        }

        public Direction(int id, string from, string to, int km, decimal price)
        {
            Id = id;
            From = from;
            To = to;
            Km = km;
            Price = price;
        }

        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Km { get; set; }
        public decimal Price { get; set; }
    }
}

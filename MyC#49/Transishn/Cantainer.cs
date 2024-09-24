using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Transishn
{
    internal class Cantainer
    {
        public Cantainer()
        {
        }

        public Cantainer(int id, bool open, decimal caficent)
        {
            Id = id;
            Open = open;
            Caficent = caficent;
        }

        public int Id { get; set; }
        public bool Open { get; set; }
        public decimal Caficent { get; set; }

    }
}

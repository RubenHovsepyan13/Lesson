using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Irepasiroti
{
    internal interface IRepasitori<T>
    {
        void Add(T t);
        T Find(int Id);
        List<T> FindAll();
        void Update(T t); 
        void Delete(int Id);
    }
}

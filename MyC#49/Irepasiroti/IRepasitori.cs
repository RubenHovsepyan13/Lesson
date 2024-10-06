using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyC_49.Irepasiroti
{
    internal interface IRepasitori<TModel, TRequest>
    {
        void Addd(TModel t);
        TModel GetById(int Id);
        List<TModel> GetAll();
        void Updatee(TModel t);
        void Deletee(int Id);
        TModel Find(TRequest request);
    }
}

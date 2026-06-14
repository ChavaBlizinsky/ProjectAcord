
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api
{
    public interface IBLCrud<T>
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        List<T> Read();
    }
}

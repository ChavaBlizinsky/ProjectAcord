using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Api
{
    public interface ICrud<T>
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        List<T> Read();
    }
}

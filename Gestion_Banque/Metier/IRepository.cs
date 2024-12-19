using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Banque.Entities
{
    internal interface IRepository<T>
    {
        
        
        List<T> add(T t);
        void update(int id);
        void delete(int id);
        List<T> list();
    }
}

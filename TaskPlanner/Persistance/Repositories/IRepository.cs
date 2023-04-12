using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Persistance.Repositories
{
    internal interface IRepository<Entity> where Entity : class
    {
        void Add(Entity entity);
        ICollection<Entity> GetAll();
        Entity Get(string id);

    }
}

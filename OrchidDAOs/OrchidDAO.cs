using OrchidBusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchidDAOs
{
    public class OrchidDAO
    {
        private readonly OrchidContext dbContext = null;

        public OrchidDAO()
        {
            if (dbContext == null)
            {
                dbContext = new OrchidContext();
            }
        }

        public List<Orchid> GetOrchids() 
        { 
            return dbContext.Orchids.ToList();
        }

        public Orchid GetOrchid(int id)
        {
            return dbContext.Orchids.FirstOrDefault(m => m.OrchidId.Equals(id));
        }

        public Orchid AddOrchid(Orchid orchid)
        {
            dbContext.Orchids.Add(orchid);
            dbContext.SaveChanges();
            return orchid;
        }

        public Orchid UpdateOrchid (int id, Orchid orchid)
        {
            Orchid o = GetOrchid(id);
            if (orchid != null)
            {
                o.OrchidName = orchid.OrchidName;
                o.IsNatural = orchid.IsNatural;
                dbContext.Update(o);
                dbContext.SaveChanges();
            }
            return o;
        }

        public void DeleteOrchid(int id)
        {
            Orchid o = GetOrchid(id);
            if (o != null)
            {
                dbContext.Remove(o);
                dbContext.SaveChanges();
            }
        }
    }
}

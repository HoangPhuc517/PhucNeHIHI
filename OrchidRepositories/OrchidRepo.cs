using OrchidBusinessObjects;
using OrchidDAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchidRepositories
{
    public class OrchidRepo : IOrchidRepo
    {
        private readonly OrchidDAO orchidDAO = null;

        public OrchidRepo()
        {
            if (orchidDAO == null)
            {
                orchidDAO = new OrchidDAO();
            }
        }
        public Orchid AddOrchid(Orchid orchid)
        {
            return orchidDAO.AddOrchid(orchid);
        }

        public void DeleteOrchid(int id)
        {
            orchidDAO.DeleteOrchid(id);
        }

        public Orchid GetOrchid(int id)
        {
            return orchidDAO.GetOrchid(id);
        }

        public List<Orchid> GetOrchids()
        {
            return orchidDAO.GetOrchids();
        }

        public Orchid UpdateOrchid(int id, Orchid orchid)
        {
            return orchidDAO.UpdateOrchid(id, orchid);
        }
    }
}

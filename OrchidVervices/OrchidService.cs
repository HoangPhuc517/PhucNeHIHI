using OrchidBusinessObjects;
using OrchidRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchidVervices
{
    public class OrchidService : IOrchidService
    {
        private readonly IOrchidRepo orchidRepo;

        public OrchidService()
        {
            if (orchidRepo == null)
            {
                orchidRepo = new OrchidRepo();
            }
        }
        public Orchid AddOrchid(Orchid orchid)
        {
            return orchidRepo.AddOrchid(orchid);
        }

        public void DeleteOrchid(int id)
        {
            orchidRepo.DeleteOrchid(id);
        }

        public Orchid GetOrchid(int id)
        {
            return orchidRepo.GetOrchid(id);
        }

        public List<Orchid> GetOrchids()
        {
            return orchidRepo.GetOrchids();
        }

        public Orchid UpdateOrchid(int id, Orchid orchid)
        {
            return orchidRepo.UpdateOrchid(id, orchid);
        }
    }
}

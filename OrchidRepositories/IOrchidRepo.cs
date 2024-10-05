using Microsoft.EntityFrameworkCore;
using OrchidBusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchidRepositories
{
    public interface IOrchidRepo
    {
        public List<Orchid> GetOrchids();

        public Orchid GetOrchid(int id);

        public Orchid AddOrchid(Orchid orchid);

        public Orchid UpdateOrchid(int id, Orchid orchid);

        public void DeleteOrchid(int id);
    }
}

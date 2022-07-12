using BaseRepo.Data;
using BaseRepo.Entity;
using BaseRepo.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepo.Repository.Developers
{
    public class DeveloperRepository : BaseRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(ApplicationDbContext context) : base(context)
        {

        }

        public List<Developer> GetTopThreeDeveloper()
        {
            return new List<Developer> { };
        }
    }
}

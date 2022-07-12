using BaseRepo.Entity;
using BaseRepo.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepo.Repository.Developers
{
    public interface IDeveloperRepository:IBaseRepository<Developer>
    {
        List<Developer> GetTopThreeDeveloper();
    }
}

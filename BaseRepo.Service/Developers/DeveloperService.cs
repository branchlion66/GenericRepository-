using BaseRepo.Entity;
using BaseRepo.Repository.Base;
using BaseRepo.Repository.Developers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepo.Service.Developers
{
    public class DeveloperService : IDeveloperService
    {
        #region DI
        private readonly IDeveloperRepository _repository;

        public DeveloperService(IDeveloperRepository repository)
        {
            _repository = repository;
        }
        #endregion
        public List<Developer> Developers()
        {

            var developers = _repository.GetAll();
            return developers;
        }
    }
}

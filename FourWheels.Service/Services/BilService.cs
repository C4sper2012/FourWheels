using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using FourWheels.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Service.Services
{
    public class BilService : GenericService<Bil, IBilRepository>, IBilService
    {
        private readonly IBilRepository _bilRepository;
        public BilService(IBilRepository GenericRepository) : base(GenericRepository)
        {
            _bilRepository = GenericRepository;
        }

    }
}

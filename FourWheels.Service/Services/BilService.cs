using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using FourWheels.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Service.Services
{
    public class BilService : GenericService<Bil, IBilRepository>, IBilService
    {
        private readonly IBilRepository _bilRepository;
        public BilService(IBilRepository genericRepository, IBilRepository bilRepository) : base(genericRepository)
        {
            _bilRepository = bilRepository;
        }


        public async Task<Bil> GetById(int id) =>
             await _bilRepository.GetById(id);
    }
}
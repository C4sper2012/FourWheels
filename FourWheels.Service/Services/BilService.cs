using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using FourWheels.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Service.Services
{
    public class BilService : GenericService<Bil, IBilRepository>, IBilService
    {
        private readonly IBilRepository _genericRepository;
        public BilService(IBilRepository genericRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public Task<List<Bil>> GetAllWithKundeAsync()
        {
            return _genericRepository.GetAllWithKundeAsync();
        }
    }
}
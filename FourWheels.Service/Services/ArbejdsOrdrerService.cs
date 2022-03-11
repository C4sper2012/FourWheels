using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using FourWheels.Repository.Repository;
using FourWheels.Service.Interfaces;

namespace FourWheels.Service.Services
{
    public class ArbejdsOrdrerService : GenericService<Arbejdsordrer, IArbejdsOrdrerRepository>, IArbejdsOrdrerService
    {
        private readonly IArbejdsOrdrerRepository _arbejdsOrdrerRepository;
        public ArbejdsOrdrerService(IArbejdsOrdrerRepository genericRepository,  IArbejdsOrdrerRepository aoRepository) : base(genericRepository)
        {
            _arbejdsOrdrerRepository = aoRepository;
        }

        public Task<List<Arbejdsordrer>> GetAllAOIncludeMek()
        {
            return _arbejdsOrdrerRepository.GetAllAOIncludeMek();
        }
    }
}
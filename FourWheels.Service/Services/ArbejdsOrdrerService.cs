using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using FourWheels.Repository.Repository;
using FourWheels.Service.Interfaces;

namespace FourWheels.Service.Services
{
    public class ArbejdsOrdrerService : GenericService<Arbejdsordrer, IArbejdsOrdrerRepository>, IArbejdsOrdrerService
    {
        public ArbejdsOrdrerService(IArbejdsOrdrerRepository genericRepository) : base(genericRepository)
        {
            
        }
    }
}
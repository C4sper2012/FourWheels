using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;

namespace FourWheels.Repository.Repository
{
    public class ArbejdsOrdrerRepository : GenericRepository<Arbejdsordrer>, IArbejdsOrdrerRepository
    {
        public ArbejdsOrdrerRepository(FourWheelsContext fourWheelsContext) : base(fourWheelsContext)
        {
        
        }
    }
}
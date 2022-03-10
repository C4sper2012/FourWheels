using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;

namespace FourWheels.Repository.Repository
{
    public class KundeRepository : GenericRepository<Kunde>, IKundeRepository
    {
        public KundeRepository(FourWheelsContext fourWheelsContext) : base(fourWheelsContext)
        {
        
        }
    }
}
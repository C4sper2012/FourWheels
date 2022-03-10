using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;

namespace FourWheels.Repository.Repository
{
    public class ServiceTypeRepository : GenericRepository<Servicetype>, IServiceTypeRepository
    {
        public ServiceTypeRepository(FourWheelsContext fourWheelsContext) : base(fourWheelsContext)
        {
        
        }
    }
}
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using FourWheels.Service.Interfaces;

namespace FourWheels.Service.Services;

public class ServiceTypeService : GenericService<Servicetype, IServiceTypeRepository>, IServiceTypeService
{
    public ServiceTypeService(IServiceTypeRepository genericRepository) : base(genericRepository)
    {
        
    }
}
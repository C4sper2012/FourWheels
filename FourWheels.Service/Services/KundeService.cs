using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using FourWheels.Service.Interfaces;

namespace FourWheels.Service.Services;

public class KundeService : GenericService<Kunde, IKundeRepository>, IKundeService
{
    public KundeService(IKundeRepository genericRepository) : base(genericRepository)
    {
    }
}
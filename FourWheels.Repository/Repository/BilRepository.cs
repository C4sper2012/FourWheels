using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;

namespace FourWheels.Repository.Repository;

public class BilRepository : GenericRepository<Bil>, IBilRepository
{
    public BilRepository(FourWheelsContext fourWheelsContext) : base(fourWheelsContext)
    {
        
    }
}
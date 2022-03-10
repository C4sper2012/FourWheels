using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;

namespace FourWheels.Repository.Repository
{
    public class BilRepository : GenericRepository<Bil>, IBilRepository
    {
        private readonly FourWheelsContext _dbContext;
        public BilRepository(FourWheelsContext fourWheelsContext) : base(fourWheelsContext)
        {
            _dbContext = fourWheelsContext;
        }
    }
}

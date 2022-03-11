using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Repository
{
    public class BilRepository : GenericRepository<Bil>, IBilRepository
    {
        private readonly FourWheelsContext _dbContext;
        public BilRepository(FourWheelsContext fourWheelsContext) : base(fourWheelsContext)
        {
            _dbContext = fourWheelsContext;
        }
        public Task<List<Bil>> GetAllWithKundeAsync()
        {
            return _dbContext.Biler
                             .Include(b => b.Kunde)
                             .ToListAsync();
        }
    }
}
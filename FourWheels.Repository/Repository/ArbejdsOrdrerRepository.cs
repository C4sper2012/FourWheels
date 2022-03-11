using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Repository
{
    public class ArbejdsOrdrerRepository : GenericRepository<Arbejdsordrer>, IArbejdsOrdrerRepository
    {
        private FourWheelsContext _dbContext;
        public ArbejdsOrdrerRepository(FourWheelsContext fourWheelsContext) : base(fourWheelsContext)
        {
            _dbContext = fourWheelsContext;
        }

        public async Task<List<Arbejdsordrer>> GetAllAOIncludeMek()
        {
            return await _dbContext.Arbejdsordrer
                .Include(m => m.Mekaiker)
                .Include(s => s.Servicetype)
                .Include(c => c.Bil)
                .ThenInclude(k => k.Kunde)
                .ToListAsync();
        }
    }
}
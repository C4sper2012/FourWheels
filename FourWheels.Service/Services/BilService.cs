using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Service.Services
{
    public class BilService : IGenericService<Bil>, IBilService
    {
        #region Bil
        private readonly FourWheelsContext _db;
        public BilService(FourWheelsContext db)
        {
            _db = db;
        }
        #endregion

        public Task CreateAsync(Bil entity)
        {
            throw new NotImplementedException();
        }
        public Task UpdateAsync(Bil entity)
        {
            throw new NotImplementedException();
        }
        public Task<List<Bil>> GetAllAsync()
        {
            return _db.Biler.ToListAsync();
        }
        public Task<Bil> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }
    }
}
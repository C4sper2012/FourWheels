using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Service.Services
{
    public class ServiceTypeService : GenericService<Servicetype>, IServiceTypeService
    {
        private readonly FourWheelsContext _db;

        public ServiceTypeService(FourWheelsContext db)
        {
            _db = db;
        }

        public Task CreateAsync(Servicetype entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Servicetype entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Servicetype>> GetAllAsync()
        {
            return _db.Servicetyper.ToListAsync();
        }

        public Task<Servicetype> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }
    }

    public class GenericService<T>
    {
    }
}
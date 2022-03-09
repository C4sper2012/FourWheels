using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Service.Services
{
    public class BilService : IBilService
    {
        public Task CreateAsync(Bil entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Bil>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Bil> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Bil entity)
        {
            throw new NotImplementedException();
        }
    }
}

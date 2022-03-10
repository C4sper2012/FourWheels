<<<<<<< HEAD
﻿using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
=======
﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
>>>>>>> 13c05fc0df2615da7b6e41a55ba33c426cb76015
using FourWheels.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD
namespace FourWheels.Service.Services;

public class ServiceTypeService : GenericService<Servicetype, IServiceTypeRepository>, IServiceTypeService
{
    public ServiceTypeService(IServiceTypeRepository genericRepository) : base(genericRepository)
    {
        
=======
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
>>>>>>> 13c05fc0df2615da7b6e41a55ba33c426cb76015
    }
}
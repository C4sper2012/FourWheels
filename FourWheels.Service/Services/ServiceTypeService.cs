using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Service.Interfaces;
using FourWheels.Service.Services;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Service.Services;

public class ServiceTypeService : GenericService<Servicetype, IServiceTypeRepository>, IServiceTypeService
{
    public ServiceTypeService(IServiceTypeRepository genericRepository) : base(genericRepository)
    {
    }
}
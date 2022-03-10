using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using FourWheels.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Service.Services
{
    public class BilService : GenericService<Bil, IBilRepository>, IBilService
    {
        public BilService(IBilRepository genericRepository) : base(genericRepository)
        {
        }
    }
}
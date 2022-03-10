using FourWheels.Repository.Domain;
using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;

namespace FourWheels.Repository.Repository
{
    public class CustomerRepository : GenericRepository<Kunde>, ICustomerRepository
    {
        public CustomerRepository(FourWheelsContext fourWheelsContext) : base(fourWheelsContext)
        {
        }
    }
}
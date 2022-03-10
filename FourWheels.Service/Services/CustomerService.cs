using FourWheels.Repository.Entities;
using FourWheels.Repository.Interfaces;
using FourWheels.Service.Interfaces;

namespace FourWheels.Service.Services;

public class CustomerService : GenericService<Kunde, ICustomerRepository>, ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    public CustomerService(ICustomerRepository genericRepository, ICustomerRepository customerRepository) : base(genericRepository)
    {
        _customerRepository = customerRepository;
    }
        
}
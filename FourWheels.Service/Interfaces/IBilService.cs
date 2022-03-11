using FourWheels.Repository.Entities;

namespace FourWheels.Service.Interfaces
{
    public interface IBilService : IGenericService<Bil>
    {
        Task<List<Bil>> GetAllWithKundeAsync();
    }
}
using FourWheels.Repository.Entities;

namespace FourWheels.Repository.Interfaces
{
    public interface IBilRepository : IGenericRepository<Bil>
    {
        Task<Bil> GetById(int id);
    }
}
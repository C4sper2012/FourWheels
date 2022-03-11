using FourWheels.Repository.Entities;

namespace FourWheels.Repository.Interfaces
{
    public interface IArbejdsOrdrerRepository : IGenericRepository<Arbejdsordrer>
    {
        Task<List<Arbejdsordrer>> GetAllAOIncludeMek();
    }
    
}
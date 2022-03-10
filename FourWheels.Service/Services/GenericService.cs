using FourWheels.Repository.Interfaces;
using FourWheels.Service.Interfaces;

namespace FourWheels.Service.Services
{
    /// <summary>
    /// Generic service
    /// </summary>
    /// <typeparam name="T">The class type</typeparam>
    public abstract class GenericService<T, I> : IGenericService<T> where T : class where I : IGenericRepository<T>
    {
        private readonly I _genericRepository;
        private readonly string _entityName = typeof(T).ToString().Replace("Repository.", "");

        protected GenericService(I genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task CreateAsync(T entity)
        {
            await _genericRepository.CreateAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _genericRepository.UpdateAsync(entity);
        }

        public async Task<List<T>> GetAllAsync()=>
        await _genericRepository.GetAllAsync();

        public Task<T> GetByIdAsync(object id)=>
        _genericRepository.GetByIdAsync(id);
    }
}
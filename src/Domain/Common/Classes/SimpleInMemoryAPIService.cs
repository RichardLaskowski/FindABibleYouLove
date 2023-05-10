using Domain.Common.Interfaces;

namespace Domain.Common.Classes;
public class SimpleInMemoryAPIService<TType, TContract> : ISimpleAPIService<TType, TContract> 
    where TType : class 
    where TContract : SimpleAPIContract<TType>
{
    private readonly SimpleInMemoryRepository<TType, SimpleEntity<TType>> _repo;

    public SimpleInMemoryAPIService()
    {
        _repo = new SimpleInMemoryRepository<TType, SimpleEntity<TType>>();
    }

    public Task<TType> CreateAsync(TContract contract) => throw new NotImplementedException();
    public Task DeleteAsync(TType id) => throw new NotImplementedException();
    public Task UpdateAsync(TType id, TContract contract) => throw new NotImplementedException();
    public Task<TContract> GetAsync(TType id) => throw new NotImplementedException();
    public Task<IEnumerable<TContract>> GetAllAsync() => throw new NotImplementedException();
}

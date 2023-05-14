using Domain.Common.Interfaces;

namespace Domain.Common.Classes;

public class BaseService<TType, TEntity, TContract> : IService<TType, TContract>
    where TType : class
    where TEntity : BaseEntity<TType>
    where TContract : BaseContract<TType>
{
    protected IRepository<TType, TEntity> _repo;
    protected IMapper<TEntity, TContract> _mapper;

    public BaseService(IRepository<TType, TEntity> repo, IMapper<TEntity, TContract> mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public Task<TContract> CreateAsync(TContract contract) => throw new NotImplementedException();
    public Task DeleteAsync(TType id) => throw new NotImplementedException();
    public Task UpdateAsync(TType id, TContract contract) => throw new NotImplementedException();
    public Task<TContract> GetAsync(TType id) => throw new NotImplementedException();
    public Task<IEnumerable<TContract>> GetAllAsync() => throw new NotImplementedException();
}

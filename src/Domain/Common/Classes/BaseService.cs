using Domain.Common.Interfaces;

namespace Domain.Common.Classes;

public abstract class BaseService<TType, TEntity, TContract> : IService<TType, TContract>
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

    public abstract Task<TContract> CreateAsync(TContract contract);
    public abstract Task DeleteAsync(TType id);
    public abstract Task UpdateAsync(TType id, TContract contract);
    public abstract Task<TContract> GetAsync(TType id);
    public abstract Task<IEnumerable<TContract>> GetAllAsync();
}

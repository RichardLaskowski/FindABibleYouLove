﻿using Domain.Base.Classes.Contracts;
using Domain.Base.Classes.Entities;
using Domain.Base.Interfaces;

namespace Domain.Base.Classes.Services;

public abstract class BaseService<TType, TEntity, TContract> : IBaseService<TType, TContract>
    where TType : class
    where TEntity : BaseEntity<TType>
    where TContract : BaseContract<TType>
{
    protected IBaseRepository<TType, TEntity> _repo;
    protected IBaseMapper<TEntity, TContract> _mapper;

    public BaseService(IBaseRepository<TType, TEntity> repo, IBaseMapper<TEntity, TContract> mapper)
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
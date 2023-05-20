﻿using Domain.Base.Classes.Contracts;

namespace Domain.Base.Interfaces.Services;

public interface IBaseService<TType, TContract>
    where TType : class
    where TContract : BaseContract<TType>
{
    Task<TType> CreateAsync(TContract contract);
    Task DeleteAsync(TType id);
    Task UpdateAsync(TType id, TContract contract);
    Task<TContract> GetAsync(TType id);
    Task<IEnumerable<TContract>> GetAllAsync();
}
using Domain.Common.Classes;

namespace Domain.Common.Interfaces;
public interface ISimpleAPIService<TType, TContract> where TType: class where TContract : SimpleAPIContract<TType>
{
    Task<TType> CreateAsync(TContract contract);
    Task DeleteAsync(TType id);
    Task UpdateAsync(TType id, TContract contract);
    Task<TContract> GetAsync(TType id);
    Task<IEnumerable<TContract>> GetAllAsync();
}

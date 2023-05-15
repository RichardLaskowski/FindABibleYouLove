using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;

using Domain.Common.Classes;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Infrastructure.Repositories.Bible;

public class BibleCategoryService<TType> : BaseService<TType, BibleCategoryEntity<TType>, BibleCategoryContract<TType>>, IBibleCategoryService<TType> where TType : class
{
    protected IBibleCategoryRepository<TType> Repository => (IBibleCategoryRepository<TType>)_repo;
    protected IBibleCategoryMapper<TType> Mapper => (IBibleCategoryMapper<TType>)_mapper;

    public BibleCategoryService(IBibleCategoryRepository<TType> repo, IBibleCategoryMapper<TType> mapper) : base(repo, mapper)
    {

    }

    public override Task<BibleCategoryContract<TType>> CreateAsync(BibleCategoryContract<TType> contract) => throw new NotImplementedException();
    public override Task DeleteAsync(TType id) => throw new NotImplementedException();
    public override Task UpdateAsync(TType id, BibleCategoryContract<TType> contract) => throw new NotImplementedException();
    public override Task<BibleCategoryContract<TType>> GetAsync(TType id) => throw new NotImplementedException();
    public override Task<IEnumerable<BibleCategoryContract<TType>>> GetAllAsync() => throw new NotImplementedException();
}
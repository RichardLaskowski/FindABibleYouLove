using Application.Mappers.Cover;
using Application.Repositories.Cover;
using Application.Services.Cover;

using Domain.Common.Classes;
using Domain.Entities.Cover;

using FindABibleYouLove.Contracts.Cover;

namespace Infrastructure.Repositories.Cover;

public class CoverService<TType> : BaseService<TType, CoverEntity<TType>, CoverContract<TType>>, ICoverService<TType> where TType : class
{
    protected ICoverRepository<TType> Repository => (ICoverRepository<TType>)_repo;
    protected ICoverMapper<TType> Mapper => (ICoverMapper<TType>)_mapper;

    public CoverService(ICoverRepository<TType> repo, ICoverMapper<TType> mapper) : base(repo, mapper)
    {

    }
}
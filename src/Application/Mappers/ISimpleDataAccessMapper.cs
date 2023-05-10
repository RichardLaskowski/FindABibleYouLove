using Domain.Common.Classes;
using Domain.Common.Interfaces;

namespace Application.Mappers;
public interface ISimpleDataAccessMapper<TType, TSimpleEntity, TSimpleAPIContract> : ISimpleMapper<TSimpleEntity, TSimpleAPIContract>
    where TType : class
    where TSimpleEntity : SimpleEntity<TType>
    where TSimpleAPIContract : SimpleAPIContract<TType>
{

}

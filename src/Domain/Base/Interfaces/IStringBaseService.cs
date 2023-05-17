using Domain.Base.Classes.Contracts;

namespace Domain.Base.Interfaces;

public interface IStringBaseService<TContract> : IBaseService<string, TContract>
    where TContract : StringBaseContract
{

}
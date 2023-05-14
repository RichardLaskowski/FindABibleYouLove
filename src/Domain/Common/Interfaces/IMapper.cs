namespace Domain.Common.Interfaces;
public interface IMapper<T, U>
{
    T Map(U value);
    U Map(T value);

    IEnumerable<T> MapAll(IEnumerable<U> values);
    IEnumerable<U> MapAll(IEnumerable<T> values);

    Task<T> MapAsync(U value);
    Task<U> MapAsync(T value);

    Task<IEnumerable<T>> MapAllAsync(IEnumerable<U> values);
    Task<IEnumerable<U>> MapAllAsync(IEnumerable<T> values);
}

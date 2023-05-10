namespace Domain.Common.Interfaces;
public interface ISimpleMapper<T, U>
{
    U Map(T value);
    T Map(U value);

    IEnumerable<T> MapAll(IEnumerable<U> values);
    IEnumerable<U> MapAll(IEnumerable<T> values);

    Task<U> MapAsync(T value);
    Task<T> MapAsyn(U value);

    Task<IEnumerable<U>> MapAllAsync(IEnumerable<T> values);
    Task<IEnumerable<T>> MapAllAsync(IEnumerable<U> values);
}

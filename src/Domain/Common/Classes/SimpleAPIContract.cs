namespace Domain.Common.Classes;

public abstract record SimpleAPIContract<TType>(TType ID) where TType : class;


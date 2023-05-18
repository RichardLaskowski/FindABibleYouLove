namespace Domain.Base.Classes.Contracts;

public abstract record BaseContract<TType>(TType Id) where TType : class { }

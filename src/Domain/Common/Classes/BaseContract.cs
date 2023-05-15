namespace Domain.Common.Classes;

public abstract record BaseContract<TType>(TType ID) 
    where TType : class
{
    internal TType ID = ID;
}
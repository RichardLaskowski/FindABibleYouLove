namespace Domain.Base.Classes.Contracts;

public abstract record StringBaseContract(string Id) : BaseContract<string>(!string.IsNullOrEmpty(Id) ? Id : Guid.NewGuid().ToString());
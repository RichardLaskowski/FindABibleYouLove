namespace Domain.Common.Classes;

public abstract class BaseEntity<TType> where TType : class
{
    internal TType? Id              { get; set; }
    internal DateTime Created       { get; set; }
    internal string? CreatedBy      { get; set; }
    internal DateTime? LastModified { get; set; }
    internal string? LastModifiedBy { get; set; }
}
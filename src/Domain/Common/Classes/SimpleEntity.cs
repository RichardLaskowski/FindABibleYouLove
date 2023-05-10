using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Common.Classes;

public abstract class SimpleEntity<TType> where TType : class
{
    #region Fields

    private readonly List<SimpleEvent> _domainEvents = new();

    #endregion Fields

    #region Properties

    public TType? Id                { get; set; }
    public DateTime Created         { get; set; }
    public string? CreatedBy        { get; set; }
    public DateTime? LastModified   { get; set; }
    public string? LastModifiedBy   { get; set; }
    [NotMapped]
    public IReadOnlyCollection<SimpleEvent> DomainEvents    => _domainEvents.AsReadOnly();

    #endregion Properties

    #region Public Methods

    public void AddDomainEvent(SimpleEvent domainEvent)     => _domainEvents.Add(domainEvent);
    public void RemoveDomainEvent(SimpleEvent domainEvent)  => _domainEvents.Remove(domainEvent);
    public void ClearDomainEvents()                         => _domainEvents.Clear();

    #endregion Public Methods
}
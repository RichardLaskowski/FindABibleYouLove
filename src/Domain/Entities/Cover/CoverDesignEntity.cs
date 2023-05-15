using Domain.Common.Classes;

namespace Domain.Entities.Cover;

public class CoverDesignEntity<TType> : BaseEntity<TType> where TType : class
{
    public CoverDesignEntity(TType id) : base(id)
    {
    }

    public CoverDesignEntity(TType id, string designName, string designDescription) : base(id)
    {
        DesignName = designName;
        DesignDescription = designDescription;
    }

    public TType? CoverDesignID => Id;
    public string DesignName { get; set; } = string.Empty;
    public string DesignDescription { get; set; } = string.Empty;
}

using Domain.Base.Classes.Entities;

namespace Domain.Entities.Cover;

public class CoverDesignEntity : StringBaseEntity
{

    public string CoverDesignId => StringId;

    public string DesignName { get; set; }

    public CoverDesignEntity() : base()
    {
        DesignName = string.Empty;
    }

    public CoverDesignEntity(string coverDesignId, string designName) : base(coverDesignId)
    {
        DesignName = designName;

    }
}

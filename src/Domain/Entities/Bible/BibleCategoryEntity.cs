using Domain.Base.Classes.Entities;

namespace Domain.Entities.Bible;

public class BibleCategoryEntity : StringBaseEntity
{
    public string BibleCategoryId => StringId;

    public string CategoryName          { get; set; }
    public string CategoryDescription   { get; set; }

    public BibleCategoryEntity() : base()
    {
        CategoryName        = string.Empty;
        CategoryDescription = string.Empty;
    }

    public BibleCategoryEntity(
        string BibleCategoryId,
        string categoryName,
        string categoryDescription) : base(stringId: BibleCategoryId)
    {
        CategoryName        = categoryName;
        CategoryDescription = categoryDescription;
    }
}
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
        string bibleCategoryId,
        string categoryName,
        string categoryDescription) : base(stringId: bibleCategoryId)
    {
        CategoryName        = categoryName;
        CategoryDescription = categoryDescription;
    }
}
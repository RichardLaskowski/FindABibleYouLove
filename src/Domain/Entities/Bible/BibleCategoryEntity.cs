using Domain.Common.Classes;

namespace Domain.Entities.Bible;

public class BibleCategoryEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? BibleCategoryID => Id;
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set;}

    public BibleCategoryEntity() : base() 
    { 
        CategoryName        = string.Empty;
        CategoryDescription = string.Empty;
    }

    public BibleCategoryEntity(
        TType bibleCategoryID,
        string categoryName,
        string categoryDescription) : base(bibleCategoryID)
    {
        CategoryName        = categoryName;
        CategoryDescription = categoryDescription;
    }
}
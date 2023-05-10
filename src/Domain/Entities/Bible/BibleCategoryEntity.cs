using Domain.Common.Classes;

namespace Domain.Entities.Bible;

public class BibleCategoryEntity<TType> : SimpleEntity<TType> where TType : class
{
    public TType? BibleCategoryID => Id;
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryDescription { get; set;} = string.Empty;
}
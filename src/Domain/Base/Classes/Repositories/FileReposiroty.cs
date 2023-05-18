using Domain.Base.Classes.Entities;

namespace Domain.Base.Classes.Repositories;

public abstract class FileRepository<TType, TEntity> : DictionaryRepository<TType, TEntity>
    where TType : class
    where TEntity : BaseEntity<TType>
{
    protected string Path { get; }
    protected string JsonString { get; set; }

    public FileRepository(string path = "") : base()
    {
        Path = !string.IsNullOrEmpty(path) ? path : Environment.CurrentDirectory.ToString();
        JsonString = string.Empty;
    }
}

using System.Text.Json;

using Domain.Base.Classes.Entities;

namespace Domain.Base.Classes.Repositories;

public abstract class FileRepository<TType, TEntity> : DictionaryRepository<TType, TEntity>, IDisposable
    where TType : class
    where TEntity : BaseEntity<TType>
{
    protected string Path { get; }
    protected string JsonString { get; set; }

    public FileRepository(string path = "") : base()
    {
        Path = !string.IsNullOrEmpty(path) ? path : Environment.CurrentDirectory.ToString();
        JsonString = string.Empty;
        Seed();
    }

    public void Dispose()
    {
        JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize<IEnumerable<TEntity>>(Dictionary.Values.ToList(), options);
        File.WriteAllText(Path, jsonString);
    }
}

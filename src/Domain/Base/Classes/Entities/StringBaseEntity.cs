namespace Domain.Base.Classes.Entities;

public abstract class StringBaseEntity : BaseEntity<string>
{
    private string _stringId;

    internal string StringId
    {
        get
        {
            if (string.IsNullOrEmpty(_stringId))
            {
                _stringId = Id != null 
                    ? Id.ToString() 
                    : Guid.NewGuid().ToString();
            }
            return _stringId;
        }
    }


    protected StringBaseEntity()
    {
        _stringId = string.Empty;
    }

    protected StringBaseEntity(string stringId) : base(stringId)
    {
        _stringId = stringId;
    }
}

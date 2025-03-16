using Core.Entities;

namespace Entities;

public class Technology : BaseEntity<Guid>
{
    public string name { get; set; }
    public ProgrammingLanguage language { get; set; }

    public Technology()
    {

    }

    public Technology(Guid id, string name, ProgrammingLanguage language)
    {
        Id = id;
        this.name = name;
        this.language = language;
    }
}
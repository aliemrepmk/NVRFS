using Core.Entities;

namespace Entities;

public class ProgrammingLanguage : BaseEntity<Guid>
{
    public string name { get; set; }
    
    public ProgrammingLanguage()
    {

    }

    public ProgrammingLanguage(Guid id, string name)
    {
        Id = id;
        this.name = name;
    }
}
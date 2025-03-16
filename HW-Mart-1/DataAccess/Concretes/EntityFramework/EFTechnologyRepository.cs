using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework;

public class EFTechnologyRepository : ITechnologyRepository
{
    private List<Technology> _technologyList;

    public EFTechnologyRepository()
    {
        _technologyList = new List<Technology>();

        //Seed data
        _technologyList.Add(new Technology(Guid.NewGuid(), "ASP.NET Core", new ProgrammingLanguage(Guid.NewGuid(), "C#")));
        _technologyList.Add(new Technology(Guid.NewGuid(), "React.js", new ProgrammingLanguage(Guid.NewGuid(), "Javascript")));
        _technologyList.Add(new Technology(Guid.NewGuid(), "Pygame", new ProgrammingLanguage(Guid.NewGuid(), "Python")));
    }

    public void Add(Technology technology)
    {
        _technologyList.Add(technology);
    }

    public List<Technology> GetAll()
    {
        return _technologyList;
    }

    public void Delete(Guid id)
    {
        Technology? technology = _technologyList.FirstOrDefault(p => p.Id == id);
        if (technology is not null)
        {
            _technologyList.Remove(technology);
        }
    }

    public void Update(Guid id, string NewName)
    {
        Technology? technology = _technologyList.FirstOrDefault(p => p.Id == id);
        if (technology is not null)
            technology.name = NewName;
    }

    public Technology GetById(Guid id)
    {
        Technology? technology = _technologyList.FirstOrDefault(p => p.Id == id);
        if (technology is not null)
            return technology;
        else
            return new Technology(Guid.NewGuid(), "Null", new ProgrammingLanguage(Guid.NewGuid(), "Null"));
    }
}
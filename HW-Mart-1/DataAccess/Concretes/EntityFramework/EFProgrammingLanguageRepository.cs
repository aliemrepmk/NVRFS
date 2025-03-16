using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework;

public class EFProgrammingLanguageRepository : IProgrammingLanguageRepository
{
    private List<ProgrammingLanguage> _languages;

    public EFProgrammingLanguageRepository()
    {
        _languages = new List<ProgrammingLanguage>();

        //Seed data
        _languages.Add(new ProgrammingLanguage(Guid.NewGuid(), "C++"));
        _languages.Add(new ProgrammingLanguage(Guid.NewGuid(), "C#"));
        _languages.Add(new ProgrammingLanguage(Guid.NewGuid(), "Java"));
    }

    public void Add(ProgrammingLanguage language)
    {
        _languages.Add(language);
    }

    public List<ProgrammingLanguage> GetAll()
    {
        return _languages;
    }

    public void Delete(Guid id)
    {
        ProgrammingLanguage? language = _languages.FirstOrDefault(p => p.Id == id);
        if (language is not null)
        {
            _languages.Remove(language);
        }
    }

    public void Update(Guid id, string NewName)
    {
        ProgrammingLanguage? language = _languages.FirstOrDefault(p => p.Id == id);
        if (language is not null)
            language.name = NewName;
    }

    public ProgrammingLanguage GetById(Guid id)
    {
        ProgrammingLanguage? language = _languages.FirstOrDefault(p => p.Id == id);
        if (language is not null)
            return language;
        else
            return new ProgrammingLanguage(Guid.NewGuid(), "Null");
    }
}
using Entities;

namespace DataAccess.Abstracts;

public interface IProgrammingLanguageRepository
{
    void Add(ProgrammingLanguage language);
    List<ProgrammingLanguage> GetAll();
    void Delete(Guid id);
    void Update(Guid id, string NewName);
    ProgrammingLanguage GetById(Guid id);
}

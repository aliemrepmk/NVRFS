using Entities;

namespace Business.Abstracts;

public interface IProgrammingLanguageService
{
    void AddLanguage(ProgrammingLanguage language);
    List<ProgrammingLanguage> GetAllLanguages();
}

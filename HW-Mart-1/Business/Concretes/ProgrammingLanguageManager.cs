using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class ProgrammingLanguageManager : IProgrammingLanguageService
{
    private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

    public ProgrammingLanguageManager(IProgrammingLanguageRepository programmingLanguageRepository)
    {
        _programmingLanguageRepository = programmingLanguageRepository;
    }

    public void AddLanguage(ProgrammingLanguage language)
    {
        _programmingLanguageRepository.Add(language);
    }

    public List<ProgrammingLanguage> GetAllLanguages()
    {
        return _programmingLanguageRepository.GetAll();
    }
}
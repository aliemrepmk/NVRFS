using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class TechnologyManager : ITechnologyService
{
    private readonly ITechnologyRepository _technologyRepository;

    public TechnologyManager(ITechnologyRepository technologyRepository)
    {
        _technologyRepository = technologyRepository;
    }

    public void AddTechnology(Technology technology)
    {
        _technologyRepository.Add(technology);
    }

    public List<Technology> GetAllTechnologies()
    {
        return _technologyRepository.GetAll();
    }

    public void DeleteTechnology(Guid id)
    {
        _technologyRepository.Delete(id);
    }

    public void UpdateTechnology(Guid id, string NewName)
    {
        _technologyRepository.Update(id, NewName);
    }

    public Technology GetById(Guid id)
    {
        return _technologyRepository.GetById(id);
    }
}
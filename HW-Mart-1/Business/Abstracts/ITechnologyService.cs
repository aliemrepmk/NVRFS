using Entities;

namespace Business.Abstracts;

public interface ITechnologyService
{
    void AddTechnology(Technology technology);
    List<Technology> GetAllTechnologies();

    void DeleteTechnology(Guid id);
    void UpdateTechnology(Guid id, string NewName);
    Technology GetById(Guid id);
}

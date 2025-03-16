using Entities;

namespace DataAccess.Abstracts;

public interface ITechnologyRepository
{
    void Add(Technology technology);
    List<Technology> GetAll();
    void Delete(Guid id);
    void Update(Guid id, string NewName);
    Technology GetById(Guid id);
}
using DataLayer.Dtos;

namespace DataLayer.Contracts;

public interface AddPersonHandler
{
    Task<int> AddPerson(AddPersonDto dto);
}
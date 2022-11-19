using DataLayer.Contracts;
using DataLayer.Dtos;

namespace DataLayer;

public class AddPersonCommandHandler : AddPersonHandler
{
    private readonly EfDataContext _context;

    public AddPersonCommandHandler(EfDataContext context)
    {
        _context = context;
    }

    public async Task<int> AddPerson(AddPersonDto dto)
    {
        var person = new Person
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName
        };
        
        _context.People.Add(person);
        await _context.SaveChangesAsync();
        
        return person.Id;
    }
}
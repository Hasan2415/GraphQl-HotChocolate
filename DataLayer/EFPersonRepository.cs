using DataLayer.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DataLayer;

public class EFPersonRepository : PersonRepository
{
    private readonly EfDataContext _context;

    public EFPersonRepository(EfDataContext context)
    {
        _context = context;
    }

    public async Task<List<Person>> GetAll()
    {
        return await _context.People.ToListAsync();
    }

    public async Task<Person?> Find(int id)
    {
        return await _context.People.SingleAsync(_ => _.Id == id);
    }
}
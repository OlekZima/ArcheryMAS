using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using ArcheryMAS.Migrations;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

public class PersonService
{
    private readonly ArcheryDbContext _dbContext;

    public PersonService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddPersonAsync(Person? person)
    {
        _dbContext.People.Add(person);
        await _dbContext.SaveChangesAsync();
    }


    public async Task<Person?> GetPeopleAsync()
    {
        return await _dbContext.People.FirstOrDefaultAsync();
    }
}
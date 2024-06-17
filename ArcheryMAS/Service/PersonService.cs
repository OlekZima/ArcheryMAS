using ArcheryMAS.Components.Pages;
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
        if (person != null) _dbContext.People.Add(person);
        await _dbContext.SaveChangesAsync();
    }


    public async Task<List<Person>> GetPeopleArchersAsync()
    {
        return await _dbContext.People
            .Include(p => p.Archer)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<List<Person>> GetPeopleArchersAsync(AddArcherssCompitions.SearchCriteria searchCriteria)
    {
        if (_dbContext == null)
            throw new InvalidOperationException("Database context is not initialized.");

        IQueryable<Person> query = _dbContext.People
            .Include(p => p.Archer)
            .AsNoTracking();

        string query2 = "Select * from Person, Archer WHERE Person.PESEL == Archer.Person_PESEL;";
        var executeSqlRaw = _dbContext.Database.ExecuteSqlRaw(query2);

        Console.WriteLine($"Searching for names containing: {searchCriteria.Names}");
        Console.WriteLine(query.ToListAsync().Result.Count);

        if (!string.IsNullOrWhiteSpace(searchCriteria.Names))
            query = query.Where(p => p.Names.Contains(searchCriteria.Names));

        Console.WriteLine(query.ToListAsync().Result.Count);

        if (!string.IsNullOrWhiteSpace(searchCriteria.Surname))
            query = query.Where(p => p.Surname.Contains(searchCriteria.Surname));

        if (!string.IsNullOrWhiteSpace(searchCriteria.PESEL))
            query = query.Where(p => p.PESEL.Contains(searchCriteria.PESEL));

        return await query.ToListAsync();
    }
}
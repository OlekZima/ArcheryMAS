using ArcheryMAS.Components.Pages;
using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using ArcheryMAS.Migrations;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

/// <summary>
/// Person service class.
/// </summary>
public class PersonService
{
    /// <summary>
    /// ArcheryDbContext field to have access to the database.
    /// </summary>
    private readonly ArcheryDbContext _dbContext;

    /// <summary>
    /// Constructor of the PersonService class.
    /// </summary>
    /// <param name="dbContext"></param>
    public PersonService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Add person to the database if it is not null.
    /// </summary>
    /// <param name="person"></param>
    public async Task AddPersonAsync(Person? person)
    {
        if (person != null) _dbContext.People.Add(person);
        await _dbContext.SaveChangesAsync();
    }


    /// <summary>
    /// Get people that are Archers from the database.
    /// </summary>
    /// <returns></returns>
    public async Task<List<Person>> GetPeopleArchersAsync()
    {
        return await _dbContext.People
            .Include(p => p.Archer)
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Get people that are Archers from the database with search criteria.
    /// </summary>
    /// <param name="searchCriteria"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
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
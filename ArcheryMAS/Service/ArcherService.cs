using ArcheryMAS.Components.Pages;
using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace ArcheryMAS.Service;

/// <summary>
/// Archer service class.
/// </summary>
public class ArcherService
{
    /// <summary>
    /// ArcheryDbContext field to have access to the database.
    /// </summary>
    private readonly ArcheryDbContext _dbContext;

    /// <summary>
    /// Constructor of the ArcherService class.
    /// </summary>
    /// <param name="dbContext"></param>
    public ArcherService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Search archers from the database with search criteria.
    /// </summary>
    /// <param name="searchCriteria"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task<List<Archer>> SearchArchersAsync(AddArcherssCompitions.SearchCriteria searchCriteria)
    {
        if (_dbContext == null)
            throw new InvalidOperationException("Database context is not initialized.");

        var query = _dbContext.Archers.AsNoTracking();


        if (!string.IsNullOrWhiteSpace(searchCriteria.Names))
        {
            query = query.Where(a => searchCriteria.Names.Contains(a.Person_PESELNavigation.Names)).AsNoTracking();
        }

        Console.WriteLine($"Searching for names containing: {searchCriteria.Names}");
        var results = await query.ToListAsync();
        Console.WriteLine($"{results.Count} archers found.");

        return await query.ToListAsync();
    }
}
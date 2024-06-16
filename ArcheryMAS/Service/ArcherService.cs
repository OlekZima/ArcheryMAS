using ArcheryMAS.Components.Pages;
using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace ArcheryMAS.Service;

public class ArcherService
{
    private readonly ArcheryDbContext _dbContext;

    public ArcherService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

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
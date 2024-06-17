using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using ArcheryMAS.Migrations;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

/// <summary>
/// President service class.
/// For adding and getting presidents.
/// To show presidents in the application.
/// </summary>
public class PresidentService
{
    /// <summary>
    /// ArcheryDbContext field to have access to the database.
    /// </summary>
    private readonly ArcheryDbContext _dbContext;

    /// <summary>
    /// Constructor of the PresidentService class.
    /// </summary>
    /// <param name="dbContext"></param>
    public PresidentService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Add president to the database.
    /// </summary>
    /// <param name="president"></param>
    public async Task AddPresidentAsync(President? president)
    {
        _dbContext.Presidents.Add(president);
        await _dbContext.SaveChangesAsync();
    }


    /// <summary>
    /// Get presidents from the database.
    /// </summary>
    /// <returns></returns>
    public async Task<President?> GetPresidentsAsync()
    {
        return await _dbContext.Presidents
            .Include(p => p.Person_PESELNavigation)
            .FirstOrDefaultAsync();
    }
}
using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

/// <summary>
/// ArcherInCompetition service class.
/// </summary>
public class ArcherInCompetitionService
{
    /// <summary>
    /// ArcheryDbContext field to have access to the database.
    /// </summary>
    private readonly ArcheryDbContext _dbContext;

    /// <summary>
    /// Constructor of the ArcherInCompetitionService class.
    /// </summary>
    /// <param name="dbContext"></param>
    public ArcherInCompetitionService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Add archer in competition to the database if it is not null.
    /// </summary>
    /// <param name="archerInCompetition"></param>
    public async Task AddArcherInCompetitionAsync(ArcherInCompetition? archerInCompetition)
    {
        Console.WriteLine("Adding archer in competition1");
        if (archerInCompetition != null) _dbContext.ArcherInCompetitions.Add(archerInCompetition);
        Console.WriteLine("Adding archer in competition2");
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Get archers in competitions from the database.
    /// </summary>
    /// <returns></returns>
    public async Task<List<ArcherInCompetition>> GetArcherInCompetitionsAsync()
    {
        return await _dbContext.ArcherInCompetitions
            .Include(a => a.Archer_Person_PESELNavigation)
            .Include(a => a.Competition_NameNavigation)
            .AsNoTracking()
            .ToListAsync();
    }
}
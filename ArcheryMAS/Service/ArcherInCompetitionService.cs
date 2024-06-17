using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

public class ArcherInCompetitionService
{
    private readonly ArcheryDbContext _dbContext;

    public ArcherInCompetitionService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddArcherInCompetitionAsync(ArcherInCompetition? archerInCompetition)
    {
        Console.WriteLine("Adding archer in competition1");
        if (archerInCompetition != null) _dbContext.ArcherInCompetitions.Add(archerInCompetition);
        Console.WriteLine("Adding archer in competition2");
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<ArcherInCompetition>> GetArcherInCompetitionsAsync()
    {
        return await _dbContext.ArcherInCompetitions
            .Include(a => a.Archer_Person_PESELNavigation)
            .Include(a => a.Competition_NameNavigation)
            .AsNoTracking()
            .ToListAsync();
    }
}
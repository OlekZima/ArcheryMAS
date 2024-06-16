using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

public class CompetitionService
{
    private readonly ArcheryDbContext _dbContext;

    public CompetitionService(ArcheryDbContext context)
    {
        _dbContext = context;
    }

    public async Task AddCompetitionAsync(Competition competition)
    {
        if (competition.Name.Length > 50)
        {
            throw new ArgumentException("Name cannot exceed 50 characters.");
        }

        if (competition.Description != null && competition.Description.Length > 200)
        {
            throw new ArgumentException("Description cannot exceed 200 characters.");
        }


        await _dbContext.Competitions.AddAsync(competition);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Competition>> GetAllCompetitionsAsync()
    {
        return await _dbContext.Competitions.AsNoTracking().ToListAsync();
    }
}
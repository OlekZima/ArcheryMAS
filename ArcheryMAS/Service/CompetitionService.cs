using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

/// <summary>
/// Competition service class.
/// </summary>
public class CompetitionService
{
    /// <summary>
    /// ArcheryDbContext field to have access to the database.
    /// </summary>
    private readonly ArcheryDbContext _dbContext;

    /// <summary>
    /// Constructor of the CompetitionService class.
    /// </summary>
    /// <param name="context"></param>
    public CompetitionService(ArcheryDbContext context)
    {
        _dbContext = context;
    }

    /// <summary>
    /// Add competition to the database.
    /// Check if the name and description are not too long.
    /// </summary>
    /// <param name="competition"></param>
    /// <exception cref="ArgumentException"></exception>
    public async Task AddCompetitionAsync(Competition competition)
    {
        if (await _dbContext.Competitions.FindAsync(competition.Name) != null)
        {
            throw new ArgumentException("Competition with this name already exists.");
        }

        if (competition.Name.Length > 50)
        {
            throw new ArgumentException("Name cannot exceed 50 characters.");
        }

        if (competition.Description != null && competition.Description.Length > 200)
        {
            throw new ArgumentException("Description cannot exceed 200 characters.");
        }

        Console.WriteLine("Adding competition");

        await _dbContext.Competitions.AddAsync(competition);
        await _dbContext.SaveChangesAsync();

        Console.WriteLine("Competition added");
    }

    /// <summary>
    /// Get all competitions from the database.
    /// </summary>
    /// <returns></returns>
    public async Task<List<Competition>> GetAllCompetitionsAsync()
    {
        return await _dbContext.Competitions.AsNoTracking().ToListAsync();
    }
}
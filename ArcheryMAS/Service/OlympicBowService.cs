using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

/// <summary>
/// OlympicBow service class.
/// </summary>
public class OlympicBowService
{
    /// <summary>
    /// ArcheryDbContext field to have access to the database.
    /// </summary>
    private readonly ArcheryDbContext _dbContext;

    /// <summary>
    /// Constructor of the OlympicBowService class.
    /// </summary>
    /// <param name="dbContext"></param>
    public OlympicBowService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Add OlympicBow to the database if it is not null.
    /// </summary>
    /// <param name="olympicBow"></param>
    public async Task AddOlympicBowAsync(OlympicBow? olympicBow)
    {
        if (olympicBow != null) _dbContext.OlympicBows.Add(olympicBow);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Get OlympicBows from the database.
    /// </summary>
    /// <returns></returns>
    public async Task<List<OlympicBow>> GetOlympicBowsAsync()
    {
        return await _dbContext.OlympicBows
            .ToListAsync();
    }

    /// <summary>
    /// Get OlympicBow by nickname (unique ID) from the database.
    /// </summary>
    /// <param name="nickname"></param>
    /// <returns></returns>
    public async Task<OlympicBow?> GetOlympicBowByIdAsync(string nickname)
    {
        Console.WriteLine("Getting bow");
        return await _dbContext.OlympicBows
            .FirstOrDefaultAsync(b => b.Bow_NickName == nickname);
    }
}
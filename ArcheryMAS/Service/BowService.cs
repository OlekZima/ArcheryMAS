using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using ArcheryMAS.Migrations;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

/// <summary>
/// Bow service class.
/// </summary>
public class BowService
{
    /// <summary>
    /// ArcheryDbContext field to have access to the database.
    /// </summary>
    private readonly ArcheryDbContext _dbContext;

    /// <summary>
    /// Constructor of the BowService class.
    /// </summary>
    /// <param name="dbContext"></param>
    public BowService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Add bow to the database if it is not null.
    /// </summary>
    /// <param name="bow"></param>
    public async Task AddBowAsync(Bow? bow)
    {
        Console.WriteLine("Adding bow1");
        if (bow != null) _dbContext.Bows.Add(bow);
        Console.WriteLine("Adding bow2");
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Get bows from the database.
    /// </summary>
    /// <returns></returns>
    public async Task<List<Bow>> GetBowsAsync()
    {
        return await _dbContext.Bows
            .ToListAsync();
    }

    /// <summary>
    /// Get all Olympic bows from the database.
    /// Inner join with the Bow table.
    /// </summary>
    /// <returns></returns>
    public async Task<List<OlympicBow>> GetOlympicBowsAsync()
    {
        return await _dbContext.OlympicBows
            .Include(b => b.Bow_NickNameNavigation)
            .ToListAsync();
    }

    /// <summary>
    /// Get Olympic bow by nickname (unique ID) from the database.
    /// </summary>
    /// <param name="nickname"></param>
    /// <returns></returns>
    public async Task<OlympicBow?> GetOlympicBowByNickNameAsync(string nickname)
    {
        return await _dbContext.OlympicBows
            .Include(b => b.Bow_NickNameNavigation)
            .FirstAsync(b => b.Bow_NickNameNavigation.NickName == nickname);
    }

    /// <summary>
    /// Update Olympic bow in the database.
    /// </summary>
    /// <param name="bow"></param>
    public async Task UpdateOlympicBowAsync(OlympicBow bow)
    {
        _dbContext.OlympicBows.Update(bow);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Get all Compound bows from the database.
    /// </summary>
    /// <returns></returns>
    public async Task<List<CompoundBow>> GetCompoundBowsAsync()
    {
        return await _dbContext.CompoundBows
            .Include(b => b.Bow_NickNameNavigation)
            .ToListAsync();
    }

    /// <summary>
    /// Update Compound bow in the database.
    /// </summary>
    /// <param name="selectedBow"></param>
    /// <exception cref="ArgumentException"></exception>
    public async void UpdateCompoundBowAsync(CompoundBow selectedBow)
    {
        if (selectedBow.OpticalZoom is < 0 or > 2.4)
        {
            throw new ArgumentException("Optical zoom must be between 0 and 2.4");
        }

        _dbContext.CompoundBows.Update(selectedBow);
        await _dbContext.SaveChangesAsync();
    }
}
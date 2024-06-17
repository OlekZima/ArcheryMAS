using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

public class BowService
{
    private readonly ArcheryDbContext _dbContext;

    public BowService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddBowAsync(Bow? bow)
    {
        Console.WriteLine("Adding bow1");
        if (bow != null) _dbContext.Bows.Add(bow);
        Console.WriteLine("Adding bow2");
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Bow>> GetBowsAsync()
    {
        return await _dbContext.Bows
            .ToListAsync();
    }

    public async Task<List<OlympicBow>> GetOlympicBowsAsync()
    {
        return await _dbContext.OlympicBows
            .Include(b => b.Bow_NickNameNavigation)
            .ToListAsync();
    }
    
    public async Task<OlympicBow?> GetOlympicBowByNickNameAsync(string nickname)
    {
        return await _dbContext.OlympicBows
            .Include(b => b.Bow_NickNameNavigation)
            .FirstAsync(b => b.Bow_NickNameNavigation.NickName == nickname);
    }

    public async Task UpdateOlympicBowAsync(OlympicBow bow)
    {
        _dbContext.OlympicBows.Update(bow);
        await _dbContext.SaveChangesAsync();
    }
}
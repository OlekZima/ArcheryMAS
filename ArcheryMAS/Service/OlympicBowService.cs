using ArcheryMAS.Context;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

public class OlympicBowService
{
    private readonly ArcheryDbContext _dbContext;

    public OlympicBowService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddOlympicBowAsync(OlympicBow? olympicBow)
    {
        if (olympicBow != null) _dbContext.OlympicBows.Add(olympicBow);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<OlympicBow>> GetOlympicBowsAsync()
    {
        return await _dbContext.OlympicBows
            .ToListAsync();
    }

    public async Task<OlympicBow?> GetOlympicBowByIdAsync(string nickname)
    {
        Console.WriteLine("Getting bow");
        return await _dbContext.OlympicBows
            .FirstOrDefaultAsync(b => b.Bow_NickName == nickname);
    }
}
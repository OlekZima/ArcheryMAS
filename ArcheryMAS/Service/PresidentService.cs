using ArcheryMAS.Context;
using ArcheryMAS.Migrations;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Service;

public class PresidentService
{
    private readonly ArcheryDbContext _dbContext;

    public PresidentService(ArcheryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddPresidentAsync(President? president)
    {
        _dbContext.Presidents.Add(president);
        await _dbContext.SaveChangesAsync();
    }
    
    
    public async Task<President?> GetPresidentsAsync()
    {
        return await _dbContext.Presidents.FirstOrDefaultAsync();
    }
}
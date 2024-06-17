using ArcheryMAS.Components;
using ArcheryMAS.Context;
using ArcheryMAS.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<PresidentService>();
builder.Services.AddScoped<PersonService>();
builder.Services.AddScoped<CompetitionService>();
builder.Services.AddScoped<ArcherService>();
builder.Services.AddScoped<ArcherInCompetitionService>();
builder.Services.AddScoped<BowService>();
builder.Services.AddScoped<OlympicBowService>();


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<ArcheryDbContext>(options =>
    options.UseSqlite("Data Source=ArcherDb.sqlite"));
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
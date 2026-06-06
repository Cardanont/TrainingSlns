using OptcgExplorer.Infrastructure.Services;
using OptcgExplorer.UseCases.Features.Cards.GetAllSetCards;
using OptcgExplorer.UseCases.Features.Cards.GetCardsBySetId;
using OptcgExplorer.UseCases.Features.Sets.GetSets;
using OptcgExplorer.UseCases.Interfaces;
using OptcgExplorer.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<GetSetsHandler>();
builder.Services.AddScoped<GetAllSetCardsHandler>();
builder.Services.AddScoped<GetCardsBySetIdHandler>();

builder.Services.AddHttpClient<ISetService, SetService>(client =>
{
    client.BaseAddress = new Uri("https://www.optcgapi.com/");
});

builder.Services.AddHttpClient<ICardService, CardService>(client =>
{
    client.BaseAddress = new Uri("https://www.optcgapi.com/");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

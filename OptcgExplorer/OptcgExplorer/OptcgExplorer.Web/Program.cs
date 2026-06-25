using OptcgExplorer.Infrastructure.Services;
using OptcgExplorer.Web.Components;

var builder = WebApplication.CreateBuilder(args);

var optcgApiUrl =
    builder.Configuration["OptcgApi:BaseUrl"]
    ?? throw new InvalidOperationException(
        "OptcgApi:BaseUrl is missing.");

void ConfigureApiClient(HttpClient client)
{
    client.BaseAddress = new Uri(optcgApiUrl);
    client.Timeout = TimeSpan.FromSeconds(15);
}

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<GetSetsHandler>();
builder.Services.AddScoped<GetAllSetCardsHandler>();
builder.Services.AddScoped<GetAllDonCardsHandler>();
builder.Services.AddScoped<GetCardsBySetIdHandler>();
builder.Services.AddScoped<GetDecksHandler>();
builder.Services.AddScoped<GetCardsByDeckIdHandler>();


builder.Services.AddHttpClient<ISetService, SetService>(ConfigureApiClient);
builder.Services.AddHttpClient<ICardService, CardService>(ConfigureApiClient);
builder.Services.AddHttpClient<IDeckService, DeckService>(ConfigureApiClient);
builder.Services.AddHttpClient<IDonCardService, DonCardService>(ConfigureApiClient);

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

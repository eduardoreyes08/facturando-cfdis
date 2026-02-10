using Edl.Api.Infrastructure;
using Edl.Api.Options;
using Edl.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<EdlApiOptions>(builder.Configuration.GetSection(EdlApiOptions.SectionName));

builder.Services.AddSingleton<ILicenseStore, InMemoryLicenseStore>();

// Registramos ambas implementaciones para poder alternar por configuración sin recompilar.
builder.Services.AddSingleton<MockEdlService>();
builder.Services.AddSingleton<EdlRealService>();

bool useMockMode = builder.Configuration.GetValue<bool>("EdlApi:UseMockMode", true);
builder.Services.AddSingleton<IEdlService>(sp =>
  useMockMode
    ? sp.GetRequiredService<MockEdlService>()
    : sp.GetRequiredService<EdlRealService>());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

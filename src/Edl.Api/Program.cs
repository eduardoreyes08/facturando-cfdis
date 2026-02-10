using Edl.Api.Infrastructure;
using Edl.Api.Options;
using Edl.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<EdlApiOptions>(builder.Configuration.GetSection(EdlApiOptions.SectionName));

builder.Services.AddSingleton<ILicenseStore, InMemoryLicenseStore>();
builder.Services.AddSingleton<IEdlService, MockEdlService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

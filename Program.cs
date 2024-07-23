using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using BallotCast.Infrastructure;
using BallotCast.Application;
using BallotCast.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Warning);
builder.Logging.AddFilter("Microsoft.EntityFrameworkCore.Infrastructure", LogLevel.Warning);

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        options.JsonSerializerOptions.WriteIndented = true;
    });

builder.Services.AddDbContext<ReferendumContext>(options =>
    options.UseSqlite("Data Source=referendum.db")
           .UseLazyLoadingProxies()
           .EnableSensitiveDataLogging());

builder.Services.AddScoped<VoterSeedService>();
builder.Services.AddScoped<ReferendumSeedService>();
builder.Services.AddScoped<VoteSeedService>();
builder.Services.AddScoped<SeedManager>();

builder.Services.AddScoped<VoterCommandService>();
builder.Services.AddScoped<VoterQueryService>();

// Register Commands
builder.Services.AddScoped<AddVoterCommand>();
builder.Services.AddScoped<UpdateVoterCommand>();
builder.Services.AddScoped<DeleteVoterCommand>();

// Register Queries
builder.Services.AddScoped<GetAllVotersQuery>();
builder.Services.AddScoped<GetVoterByIdQuery>();
builder.Services.AddScoped<GetVoterInsightsQuery>();

// Register Repositories
builder.Services.AddScoped<IVoterRepository, VoterRepository>();
builder.Services.AddScoped<IVoteRepository, VoteRepository>();
builder.Services.AddScoped<IReferendumRepository, ReferendumRepository>();
builder.Services.AddScoped<IVoterReferendumRepository, VoterReferendumRepository>();
builder.Services.AddScoped<IParagraphRepository, ParagraphRepository>();
builder.Services.AddScoped<IReferendumResultRepository, ReferendumResultRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BallotCast API", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BallotCast API v1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseAuthorization();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var seedManager = services.GetRequiredService<SeedManager>();
    seedManager.SeedData();
}

app.Run();
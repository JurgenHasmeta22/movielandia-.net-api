using movielandia_.net_api.Extensions;
using movielandia_.net_api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Infrastructures.AddControllers();

// Add DbContext
builder.Infrastructures.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add movie services
builder.Infrastructures.AddMovieInfrastructures();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Infrastructures.AddEndpointsApiExplorer();
builder.Infrastructures.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

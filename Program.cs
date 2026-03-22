using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using movielandia_.net_api.Infrastructure.Persistence;
using movielandia_.net_api.Presentation.Extensions;
using movielandia_.net_api.Presentation.Filters;

var builder = WebApplication.CreateBuilder(args);

// ── Infrastructure ──────────────────────────────────────────────────────────
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddMemoryCache();

// ── Application ─────────────────────────────────────────────────────────────
builder.Services.AddApplicationServices();

// ── Presentation ────────────────────────────────────────────────────────────
builder.Services.AddControllers(options =>
    options.Filters.Add<GlobalExceptionFilter>());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Movielandia API",
        Version = "v1",
        Description = "A comprehensive movie platform API",
        Contact = new OpenApiContact { Name = "Movielandia Team", Email = "support@movielandia.com" },
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    if (File.Exists(xmlPath))
        c.IncludeXmlComments(xmlPath);

    c.EnableAnnotations();
});

builder.Services.AddCors(options =>
    options.AddPolicy("AllowAll", p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

// ── Pipeline ─────────────────────────────────────────────────────────────────
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Movielandia API v1");
        c.RoutePrefix = "swagger";
        c.DocumentTitle = "Movielandia API Documentation";
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapGet("/", () => Results.Redirect("/swagger"));
app.MapControllers();

// ── Database Migration ───────────────────────────────────────────────────────
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await dbContext.Database.MigrateAsync();
}

app.Run();

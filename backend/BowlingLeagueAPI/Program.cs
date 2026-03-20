using BowlingLeagueAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add Entity Framework Core with SQLite database
var connectionString = "Data Source=BowlingLeague.sqlite";
builder.Services.AddDbContext<BowlingContext>(options =>
    options.UseSqlite(connectionString));

// Add controller support for API endpoints
builder.Services.AddControllers();

// Add CORS policy to allow requests from the React frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000")  // Explicitly allow React frontend
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
// CORS must be applied early in the middleware pipeline
app.UseCors("AllowReactApp");

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    // Disable HTTPS redirect in development so HTTP requests work
    // comment out the line below if you want HTTPS
}

// app.UseHttpsRedirection(); // Commented out for development - React uses HTTP

app.UseAuthorization();

// Map controller routes
app.MapControllers();

// Configure the server to listen on HTTP port 7000 (avoiding port 5000 which is used by macOS)
app.Urls.Clear();
app.Urls.Add("http://localhost:7000");

app.Run();

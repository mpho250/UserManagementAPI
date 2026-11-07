
using UserManagementAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Register controller services
builder.Services.AddControllers();

// Build the application
var app = builder.Build();

// Enable HTTPS redirection
app.UseHttpsRedirection();

// Register custom logging middleware
app.UseMiddleware<LoggingMiddleware>();

// Enable authorization
app.UseAuthorization();

// Map API controllers
app.MapControllers();

// Run the application
app.Run();

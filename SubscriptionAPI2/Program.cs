var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
        builder.AllowAnyOrigin()   // Allow requests from any origin
               .AllowAnyMethod()   // Allow all HTTP methods (GET, POST, etc.)
               .AllowAnyHeader()); // Allow any headers
});

var app = builder.Build();


app.UseHttpsRedirection();

// Use CORS
app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();

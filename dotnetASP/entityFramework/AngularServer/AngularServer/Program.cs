using AngularApp1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

//for automated api discovery in swager
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

//dependency injection for payment context -> connect to sql server
builder.Services.AddDbContext<PaymentContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "payment detail form API",
        Version = "v1"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//we add this to allow angular site on 4200 to communicate with our server at 7155 with any CRUD methods
app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200")
           .AllowAnyMethod()
           .AllowAnyHeader();
});

app.Run();

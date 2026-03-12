using BookManagement.Application.Interfaces;
using BookManagement.Application.Services;
using BookManagement.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddScoped<IBookRepository>(_ => new BookRepository(connectionString));
builder.Services.AddScoped<BookService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

var app = builder.Build();

app.MapOpenApi();
app.UseCors("AllowAll");
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
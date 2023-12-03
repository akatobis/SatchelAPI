using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using Satchel.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("Satchel");

builder.Services.AddDbContext<SatchelDbContext>(options =>
    options.UseSqlServer(connectionString ??
                         throw new InvalidOperationException("Connection string 'Satchel' not found")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
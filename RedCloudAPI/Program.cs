using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RedCloud.Application.Contract.Persistence;
using RedCloud.Persistenence;
using RedCloud.Persistenence.Repositories;
using RedCloudAPI.Controllers;
using System;
using RedCloud.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

// Add MediatR
builder.Services.AddApplicationServices();

builder.Services.AddControllers();



builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

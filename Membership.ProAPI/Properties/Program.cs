using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System;
using Membership.ProAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Connection string
var connString = "Data Source=DESKTOP-1PD84L4\\SQLExpress;Initial Catalog=Database1;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True";
   builder.Services
    .AddDbContext<Membership.ProAPI.AppDbContext>(o => o.UseSqlServer(connString));
IServiceCollection serviceCollection = builder.Services
    .AddScoped<IMembersService, MemberService>()
    .AddScoped<IMembershipService, MembershipService>(); // Register membership service


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

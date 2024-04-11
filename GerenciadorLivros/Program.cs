using FluentValidation.AspNetCore;
using GerenciadorLivros.application.Services.implementations;
using GerenciadorLivros.application.Services.interfaces;
using GerenciadorLivros.application.Validators;
using GerenciadorLivros.intraestructure.Persistance;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(fvc=>fvc.RegisterValidatorsFromAssemblyContaining<CreateAvaliationValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("GerenciadorLivros");
builder.Services.AddDbContext<GerenciadorLivrosDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IBookService,BookService>();
builder.Services.AddScoped<IUserService, UserService>();
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

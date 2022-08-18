using ioc_di_dip.Context;
using ioc_di_dip.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

// Implementando DI do contexto e do repositório
builder.Services.AddDbContext<ExemploContext>(x => x.UseSqlite("DataSource=exemplo.db;Cache=Shared"));

// builder.Services.AddTransient<UsuarioRepositorio>();

// Implementando DIP
builder.Services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();

var app = builder.Build();

DbCreateHelper.EnsureCreatedDb(app).Wait();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

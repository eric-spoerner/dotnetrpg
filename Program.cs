global using dotnetrpg.Models;
using dotnetrpg.Services.CharacterService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// enforces CharacterService as used service during DI into controller
builder.Services.AddScoped<ICharacterService, CharacterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); //Solution for APi testing.
}

//"Use" funcs are middleware extensions
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

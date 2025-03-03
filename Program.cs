using SQLitePCL;  // Adicione esta linha para inicializar o SQLite
using Person.Data;
using Person.Routes;

var builder = WebApplication.CreateBuilder(args);

// Inicializa o SQLite
Batteries.Init();  // Inicialização do SQLitePCL

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PersonContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.PersonRoutes();

app.UseHttpsRedirection();
app.Run();
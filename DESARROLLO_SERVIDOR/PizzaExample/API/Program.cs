using PizzaExample.Business;
using PizzaExample.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<PizzaService, PizzaService>();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("ServerDB");

builder.Services.AddDbContext<PizzaContext>(options =>
    options.UseSqlServer(connectionString));
  builder.Services.AddScoped<IPizzaRepository, PizzaEFRepository>();

// builder.Services.AddScoped<IPizzaRepository, PizzaSqlRepository>(serviceProvider => 
//     new PizzaSqlRepository(connectionString));
//     builder.Services.AddScoped<IIngredientesRepository, IngredienteSqlRepository>(serviceProvider => 
//     new IngredienteSqlRepository(connectionString));    



//  builder.Services.AddSingleton<IPizzaRepository, PizzaSqlRepository>();
//  builder.Services.AddScoped<PizzaService>();
//  builder.Services.AddScoped<IngredienteService>();
//  builder.Services.AddSingleton<IIngredientesRepository, IngredienteSqlRepository>();
//  builder.Services.AddScoped<IngredienteService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddScoped<IPizzaService, PizzaService>();


// builder.Services.AddDbContext<PizzaContext>(options =>
//     options.UseSqlServer(connectionString));
//   builder.Services.AddScoped<IPizzaRepository, PizzaEFRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

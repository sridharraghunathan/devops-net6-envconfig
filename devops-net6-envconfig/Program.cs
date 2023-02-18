var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//For getting the Current Environment
/*
var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var environment = config.GetSection("EnvironmentName").Value;
builder.Configuration.AddJsonFile("appsettings.json").AddJsonFile($"appsettings.{environment}.json");
*/
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

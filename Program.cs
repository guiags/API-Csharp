using MyfirstAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRouting(option => option.LowercaseUrls = true);// Deixando as Urls dos endpoints somente com letras minusculas

var teste = builder.Configuration.GetSection("Object").GetSection("Prop1").Value;//Buscar valores de appsettings.json e devel
teste = builder.Configuration.GetSection("Object").GetSection("Prop2").Value;
teste = builder.Configuration.GetSection("Object").GetSection("PropA").Value;
var teste2 = builder.Configuration.GetSection("Myclass").Get<Myclass>();


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

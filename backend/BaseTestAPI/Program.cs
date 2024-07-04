using BaseTestAPI.Services;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddScoped<CalculatorService>();
}
var app = builder.Build();
{
    app.MapGet("/", () => "BaseTestAPI");
}
app.Run();

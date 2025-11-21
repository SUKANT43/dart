var builder = WebApplication.CreateBuilder(args);//-->args is for taking a value from the cli dotnet run --urls http://localhost:7000

var app = builder.Build();

app.MapGet("/", () => "Hello Hey!");


app.Run();

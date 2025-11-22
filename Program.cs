using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);//-->args is for taking a value from the cli dotnet run --urls http://localhost:7000

var app = builder.Build();

List<GameDto> games = new List<GameDto>()
{
    new GameDto(1, "GTA V", "Action", 999.99m, new DateOnly(2013, 9, 17)),
    new GameDto(2, "Minecraft", "Sandbox", 1999.50m, new DateOnly(2011, 11, 18)),
    new GameDto(3, "FIFA 24", "Sports", 4999.00m, new DateOnly(2023, 9, 29)),
    new GameDto(4, "Elden Ring", "RPG", 3999.00m, new DateOnly(2022, 2, 25)),
    new GameDto(5, "Call of Duty: Modern Warfare II", "Shooter", 5999.00m, new DateOnly(2022, 10, 28)),
    new GameDto(6, "The Witcher 3", "RPG", 2499.00m, new DateOnly(2015, 5, 19)),
    new GameDto(7, "Cyberpunk 2077", "RPG", 3499.00m, new DateOnly(2020, 12, 10)),
    new GameDto(8, "Red Dead Redemption 2", "Action-Adventure", 4499.00m, new DateOnly(2018, 10, 26)),
    new GameDto(9, "God of War Ragnarok", "Action", 4999.00m, new DateOnly(2022, 11, 9)),
    new GameDto(10, "PUBG", "Battle Royale", 0.00m, new DateOnly(2017, 12, 20))
};

app.MapGet("/games",()=>games);

app.MapGet("/", () => "Hello Hey!");



app.Run();

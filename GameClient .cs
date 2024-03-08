using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
       new Game()
       {
        Id=1,
        Name="GTA V",
        Genre="Action",
        Price=19.99M,
        ReleaseDate=new DateTime(2013,9,17)
       },
       new Game()
       {
        Id=2,
        Name="Minecraft",
        Genre="Adventure",
        Price=10.99M,
        ReleaseDate=new DateTime(2012,5,18)
       },
       new Game()
       {
        Id=3,
        Name="WatchDogs",
        Genre="Suspense",
        Price=20.99M,
        ReleaseDate=new DateTime(2015,6,19)
       },
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }
}
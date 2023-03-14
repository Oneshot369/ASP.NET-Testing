using ASP.NET_Testing.Models;

namespace ASP.NET_Testing.Data
{
    public interface IGameData
    {
        Game addGame(Game gameToAdd);
        int removeGame(string id);
        List<Game> updateGame(Game gameToUpdate);
        List<Game> getAllGames();
    }
}

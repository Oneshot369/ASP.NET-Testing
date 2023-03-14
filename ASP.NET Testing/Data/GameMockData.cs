using ASP.NET_Testing.Models;

namespace ASP.NET_Testing.Data
{
    public class GameMockData : IGameData
    {
        private List<Game> games;
        public void initList()
        {
            games = new List<Game>();
            games.Add(new Game("001", "Leage of Ledgens", "MOBA", 0.0f, 'E'));
            games.Add(new Game("002", "Destiny", "FPS, RPG, MMO", 0.0f, 'T'));
            games.Add(new Game("003", "ARK", "Survial", 60.0f, 'M'));
        }
        public Game addGame(Game gameToAdd)
        {
            if (games == null)
            {
                initList();
            }
            games.Add(gameToAdd);
            return gameToAdd;
        }

        public List<Game> getAllGames()
        {
            if (games == null)
            {
                initList();
            }
            return games;
        }

        public int removeGame(string id)
        {
            throw new NotImplementedException();
        }

        public List<Game> updateGame(Game gameToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

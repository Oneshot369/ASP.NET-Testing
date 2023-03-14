using ASP.NET_Testing.Models;
using MongoDB.Driver;

namespace ASP.NET_Testing.Data
{
    public class MongoGameDAO
    {
        private readonly IMongoCollection<Game> _games;
        public MongoGameDAO()
        {
            var client = new MongoClient("mongodb+srv://Ace:squirty115@cluster0.og5dfyn.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("game-store");
            _games = database.GetCollection<Game>("games");
        }

        public async Task Create(Game song)
        {
            await _games.InsertOneAsync(song);
        }
        public List<Game> GetAll()
        {
            return _games.Find(_ => true).ToList();
        }
    }
}

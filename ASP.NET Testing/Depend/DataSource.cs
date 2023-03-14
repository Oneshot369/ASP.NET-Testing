using ASP.NET_Testing.Data;

namespace ASP.NET_Testing.Depend
{
    public class DataSource
    {
        public static IGameData getDataSource()
        {
            return new MongoGameDAO();
        }
    }
}

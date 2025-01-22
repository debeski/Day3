using System.Linq;
namespace PlayerList
{
    public class PlayerHandler
    {
        static List<Player> listPlayers=new List<Player>
        {
            new Player{Id=1,Name="John Doe",Team="Batman"},
            new Player{Id=2,Name="Jane Smith",Team="Superman"},
            new Player{Id=3,Name="Mike Johnson",Team="Wonder Woman"},
            new Player{Id=4,Name="Abu Baker",Team="JusticeLeague"}
        };
        public static Player PlayerDetails(int id)
        {
            var player=listPlayers.SingleOrDefault(e=>e.Id==id);
            if (player!=null)
            {
                System.Console.WriteLine("Found");
            }
            else
            {
                System.Console.WriteLine("Not Found");
            }
            return player;
        }
        public static List<Player> AllPlayers()
        {
            return listPlayers;
        }
    }
}
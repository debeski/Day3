using PlayerList;

Console.WriteLine("Player List as follows:");
foreach(var p in PlayerHandler.AllPlayers())
{
    System.Console.WriteLine("ID: \t "+p.Id + "\t Name: \t" + p.Name +"\t Team: \t"+p.Team);
}
Console.Read();
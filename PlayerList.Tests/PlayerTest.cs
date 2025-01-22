namespace PlayerList.Tests;
public class PlayerTest
{
    [Fact]
    public void UniqueIdTest()
    {
        Assert.Equal(PlayerHandler.AllPlayers().Count,PlayerHandler.AllPlayers().Select(e=>e.Id).Distinct().Count());
    }

    [Fact]
    public void SearchByIdTest()
    {
        int id=1;
        var p=PlayerHandler.PlayerDetails(1);
        Assert.Equal(id,p.Id);
    }
}
namespace HackerRankTest;

public class HourGlassSumTest
{
    [Fact]
    public void Test1()
    {
        var result = new HourGlassSum().RunHourGlassSum();
        Assert.Equal(19, result);
    }
}
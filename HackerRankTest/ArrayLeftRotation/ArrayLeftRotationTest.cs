namespace HackerRankTest;

public class ArrayLeftRotationTest

{
    [Fact]
    public void Test1()
    {
        var result = new ArrayLeftRotation().RunArrayLeftRotation();
        Assert.Equal(new List<int>(){5,1,2,3,4}, result);
    }
}

namespace HackerRankTest.TreePreOrderTraversal;

public class TreePreOrderTraversalTest
{
    [Fact]
    public void GetPreOrderTest()
    {
        var result = new TreePreOrderTraversal().RunTreePreOrderTraversal();
        Assert.Equal(result, "1 2 5 3 4 6");
    }
    
}
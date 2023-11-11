namespace HackerRankTest;

public class ArrayLeftRotation
{
    public List<int> RunArrayLeftRotation()
    {
        var path = Path.Combine(Environment.CurrentDirectory,
            "ArrayLeftRotation/input.txt");
        var contents = File.ReadAllLines(path);
        var numberOfIndexes = Int32.Parse(contents[0].Split(" ")[1]);
        var arr = contents[1].Split(" ").Select(item => Int32.Parse(item))
            .ToList();
        return rotateLeft(numberOfIndexes, arr);
    }
    public static List<int> rotateLeft(int d, List<int> arr)
    {
        LinkedList<int> newArray = new LinkedList<int>(arr);
        for (int i = 0; i < d; i++)
        {
            var newValue = newArray.First;
            newArray.AddLast(newValue.Value);
            newArray.RemoveFirst();
        }

        return new List<int>(newArray);
    }
    
    
}
namespace HackerRankTest;

public class HourGlassSum
{
    public int RunHourGlassSum()
    {
        var path = Path.Combine(Environment.CurrentDirectory,
            "HourGlassSum/HourGlassSumInput1.txt");
        var contents = File.ReadAllLines(path);

        var arr = contents.Select(row =>
            row.Split(" ").Select(item => Int32.Parse(item)).ToList()).ToList();

        

        int result = GetHourClassSum(arr);

        return result;
    }

    public int GetHourClassSum(List<List<int>> arr)
    {
        var hourGlasses = new List<int>();
        for (int i = 0; i <4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                var firstRow = arr[j+0];
                var secondRow = arr[j+1];
                var thirdRow = arr[j+2];
                var topHourGlass = firstRow.Skip(i).Take(3);
                var middle = secondRow.Skip(i + 1).Take( 1);
                var bottomHourGlass = thirdRow.Skip(i).Take( 3);
                var total = topHourGlass.Concat(middle).Concat(bottomHourGlass)
                    .Sum();
                hourGlasses.Add(total);
            }
        }

        return hourGlasses.Max();
    }
}
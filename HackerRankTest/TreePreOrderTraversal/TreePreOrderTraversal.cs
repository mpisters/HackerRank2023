using System.Text.RegularExpressions;

namespace HackerRankTest.TreePreOrderTraversal;

public class TreePreOrderTraversal
{
    public string RunTreePreOrderTraversal()
    {
        var path = Path.Combine(Environment.CurrentDirectory,
            "TreePreOrderTraversal/input.txt");
        var contents = File.ReadAllLines(path);
        var contentWithoutSpaces = contents.Select(x => x.Trim());
        var contentSplitted = contentWithoutSpaces.Select(x => Regex.Split(x,@"\s+"));
        return GetTreePreOrderTraversal(contentSplitted);
    }



    public string GetTreePreOrderTraversal(IEnumerable<string[]> content)
    {
        var sortedItems = new List<string>();
        var otherItems = new List<string>();
        for (var i = 0; i < content.Count(); i++)
        {
            var items = content.ElementAt(i);
            var isNumeric = int.TryParse(items.ElementAt(0), out _);
            if (!isNumeric) continue;
            sortedItems.Add(items.ElementAt(0));

            if (items.Length == 2)
            {
                otherItems.Add(items.ElementAt(1));
            }
        }

        var allItems = string.Join(" ",sortedItems.Concat(otherItems));
        return allItems;
    }

    
}
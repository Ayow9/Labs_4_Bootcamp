//You use the LINQ library to ask visual studio a question about your collection of ints, doubles, moneys; and get back an answer

int[] nums = { 10, 2330, 112_233, 12, 949, 3764, 2942, 523_863 }; //#_### == #,###

//Min
Console.WriteLine(nums.Min());

//Max
Console.WriteLine(nums.Max());

//Max <10000
Console.WriteLine(nums.Where(x => x < 10000).Max()); //where filters

//all values x > 9, x < 100
List<int> range1 = nums.Where(x => x > 9 && x < 100).ToList();

    Console.WriteLine(string.Join(", ", range1));

//all values x >= 100000, x <= 999999
List<int> range2 = nums.Where(x => x >= 100000 && x <= 999999).ToList();

    Console.WriteLine(string.Join(", ", range2));

//count even numbers
List<int> even = nums.Where(x => x % 2 == 0).ToList(); 
foreach (int x3 in even)
{
    Console.WriteLine(x3);
}
//int even = nums.Where(x => x % 2 == 0).Count(); 
//Console.WriteLine(even);
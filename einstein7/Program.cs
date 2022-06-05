// See https://aka.ms/new-console-template for more information
//List<int> ints = new List<int> { 11, 69, 96, 88, 16, 16, 18, 18, 19, 19, 61, 61, 66, 68, 91, 91, 81, 81, 99 };
List<int> ints = new List<int> { 11, 16, 18, 19, 61, 66, 68,69,81, 86, 88, 89, 91, 96, 99, 98 };
List<int> unuiques = new List<int>();

unuiques = (List<int>)ints.Distinct().ToList();
unuiques.Sort();

Console.WriteLine("Unique pieces:");
foreach (var v in unuiques)
{
    Console.WriteLine(v);
}

Console.WriteLine("");
Console.WriteLine("Combinations summing up to 264:");
int sum=0;

for(int column1 = 0; column1 < ints.Count; column1++)
{
    for(int column2 = column1+1; column2 < ints.Count; column2++)
    {
        for(int column3 = column2+1; column3<ints.Count; column3++)
        {
            for(int column4=column3+1; column4 < ints.Count; column4++)
            {
                sum = ints[column1] + ints[column2]+ ints[column3]+ ints[column4];
                if(sum == 264)
                    Console.WriteLine($"Sum={sum}:{ints[column1]},{ints[column2]},{ints[column3]},{ints[column4]}");
            }
        }        
    }
}

//foreach(var item in ints)
//{
//    Console.WriteLine(item);
//    for(var i = 0; i < ints.Count; i++)
//    {
//        sum += item;
//    }
//    sum = 0;
//}

//while (num > 0)
//{
//    n = num;
//    for (int i = n - 1; i > 0; i--)
//    {
//        n *= i;
//    }
//    Console.WriteLine("Factorial of {0}! = {1}\n", num, n);
//    num--;
//}

//Console.WriteLine(sum);

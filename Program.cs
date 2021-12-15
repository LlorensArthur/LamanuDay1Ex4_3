Console.WriteLine("Hello, World!");
List<int> numberList = new List<int>();
numberList.Add(1);
numberList.Add(2);
numberList.Add(3);
numberList.Add(4);
int result = 0;
foreach (var item in numberList)
{
    result += item;
}
Console.Write("Voici les nombres qui vont être calculés : ");
foreach (var item in numberList)
{
    Console.Write($"{item}, ");
}
Console.WriteLine();
Console.WriteLine($"Le résultat de ces nombres est {result}");
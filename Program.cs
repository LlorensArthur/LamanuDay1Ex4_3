List<int> numbers = new List<int>();
// Ajout manuel de nombres
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
// Addition de la liste des nombres 
int result = 0;
foreach (var item in numbers)
{
    result += item;
}
// Affichage de l'opération pour l'utilisateur
Console.Write("Voici les nombres qui vont être calculés : ");
for (int i = 0; i < numbers.Count; i++)
{
    if(i == numbers.Count - 1)
    {
        Console.Write($"{i}.");
    }
    else
    {
        Console.Write($"{i}, ");
    }
}
Console.WriteLine();
Console.WriteLine($"Le résultat de ces nombres est {result}");
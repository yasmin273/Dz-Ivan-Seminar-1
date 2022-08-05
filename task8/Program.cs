// //Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N

IReadOnlyList<int> EvenNumbers(int N)
{
    var evenNums = new List<int>();
    for (int i = 2; i <= N; i += 2)
        evenNums.Add(i);

    return evenNums;
}

Console.Write("Введите число N: ");
var N = int.Parse(Console.ReadLine());


Console.WriteLine($"{N} -> {string.Join(", ", EvenNumbers(N))}");
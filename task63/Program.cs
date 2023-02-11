// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


string recursion(int num)
{
    return num != 1 ? (recursion(num - 1) + ", " + num) : num.ToString();
}
Console.Clear(); Console.Write("N = "); int N = int.Parse(Console.ReadLine()!);
Console.SetCursorPosition(6, 0);
Console.WriteLine($"-> \"{recursion(N)}\"");


/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


string Recursion(int num)
{
    return num != 1 ? (num + ", " + Recursion(num - 1)) : num.ToString();
}

dynamic input(string text = "", string type = "str") // just for fun
{
    while (true)
    {
        try {
            Console.Write(text);
            switch (type)
            {
                case "str": return Console.ReadLine()!;
                case "double": return double.Parse(Console.ReadLine()!);
                case "int": return int.Parse(Console.ReadLine()!);
            }
            return "Developer type error!";
        }
        catch (FormatException) { Console.WriteLine("Wrong format!"); }
    }
}

Console.Clear();
var N = input("N = ", "int");
Console.SetCursorPosition(5 + N.ToString().Length, 0);
Console.WriteLine($"-> \"{Recursion(N)}\"");
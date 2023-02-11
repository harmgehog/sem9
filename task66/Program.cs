/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

// снова сценаристы перепутали n и m


int Recursion(int m, int n)
{
    return m != n ? (m + Recursion(m + 1, n)) : 0;
}

dynamic input(string text = "", string type = "str") // not for check just for fun
{
    while (true){
        try {
            Console.Write(text);
            switch (type) {
                case "str": return Console.ReadLine()!;
                case "double": return double.Parse(Console.ReadLine()!);
                case "int": return int.Parse(Console.ReadLine()!);
            }
            return "Senior developer type error!"; }
        catch (FormatException) { Console.WriteLine("Wrong format!"); }}
}

var M = input("M = ", "int");
var N = input("N = ", "int");

Console.WriteLine($"-> \"{Recursion(M, N) + N}\"");
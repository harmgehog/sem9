/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

static int Ackermann(int n, int m) // 4x4 stack overflow need to use uint 
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return Ackermann(n - 1, 1);
    else return Ackermann(n - 1, Ackermann(n, m - 1));
}

dynamic input(string text = "", string type = "str") // not for check just for fun
{
    while (true) {
        try {
            Console.Write(text);
            switch (type) {
                case "str": return Console.ReadLine()!;
                case "double": return double.Parse(Console.ReadLine()!);
                case "int": return int.Parse(Console.ReadLine()!); }
            return "Senior developer type error!";} 
        catch (FormatException) { Console.WriteLine("Wrong format!"); }}}

Console.Clear();
var N = input("N = ", "int");
var M = input("M = ", "int");

Console.WriteLine($"-> A({N},{M}) = {Ackermann(N, M)}");
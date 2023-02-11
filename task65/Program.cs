/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */


int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
double GetNumDouble(string text){
    Console.Write(text);
    return double.Parse(Console.ReadLine()!);
}
int SumDigits(int number)
{
    if (number == 0){
        return 0;
    }
    return number % 10 + SumDigits(number/10);
}
double Power(double number, int power){
    if (power == 0){
        return 1;
    }
    if (power > 0) return Power(number,power-1) * number;
    return Power(number,power+1) * (1 / number);
}

Console.WriteLine("Task 1");
int number = GetNum("Введите число: ");
Console.WriteLine($"Сумма цифр числа {number}: {SumDigits(number)}");
Console.WriteLine("------------------");
Console.WriteLine("Task 2");
double baseNumber = GetNumDouble("Введите основание: ");
int power = GetNum("Введите степень: ");
Console.WriteLine($"{baseNumber} в степени {power} : {Power(baseNumber,power)}");
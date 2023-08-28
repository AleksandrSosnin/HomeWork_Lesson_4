/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число A:");
        double A = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите степень B:");
        int B = int.Parse(Console.ReadLine());

        double result = CalculatePower(A, B);

        Console.WriteLine($"{A} в степени {B} равно {result}");
    }

    static double CalculatePower(double baseValue, int exponent)
    {
        double result = 1;

        for (int i = 1; i <= exponent; i++)
        {
            result *= baseValue;
        }

        return result;
    }
}


/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()); // Читаем число с клавиатуры

        int sum = 0; // Инициализируем переменную для хранения суммы цифр

        while (number > 0)
        {
            int digit = number % 10; // Получаем последнюю цифру числа
            sum += digit; // Добавляем цифру к сумме
            number /= 10; // Убираем последнюю цифру из числа
        }

        Console.WriteLine($"Сумма цифр числа: {sum}");
    }
}


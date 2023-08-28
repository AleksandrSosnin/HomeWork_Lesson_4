/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/



class Program
{
    static void Main(string[] args)
    {
        int N;           // Количество элементов в массиве
        int[] array;     // Массив целых чисел

        Console.Write("Введите количество элементов: ");
        N = int.Parse(Console.ReadLine());
        array = new int[N];
        Random random = new Random();

        for (int i = 0; i < N; i++)
        {
            array[i] = random.Next(1, 100);
        }

    Console.WriteLine("Элементы массива:");

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Элемент {i + 1}: {array[i]}");
        }
    }
}


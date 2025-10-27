using Tyuiu.RagozinaAD.Sprint4.Task2.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов                     *");
        Console.WriteLine("* в диапазоне от 4 до 9 подсчитать сумму нечетных элементов массива.      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            array[i] = rnd.Next (4,9);
        }
        Console.WriteLine("Массив:");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine(array[i]+"\t");
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(array);

        Console.WriteLine("Сумма нечетных элементов = "+res);
        Console.ReadKey();

    }
}
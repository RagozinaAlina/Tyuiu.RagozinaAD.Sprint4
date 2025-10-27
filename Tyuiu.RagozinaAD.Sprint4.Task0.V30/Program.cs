using Tyuiu.RagozinaAD.Sprint4.Task0.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив заполненный статическими значениями *");
        Console.WriteLine("* в диапазоне от 0 до 9 подсчитать сумму четных элементов массива.        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.Write(array[i]+"");
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Результат:");

        Console.WriteLine("Сумма четных элементов = " + ds.GetSumEvenArrEl(array));
        Console.ReadKey();

    }
}
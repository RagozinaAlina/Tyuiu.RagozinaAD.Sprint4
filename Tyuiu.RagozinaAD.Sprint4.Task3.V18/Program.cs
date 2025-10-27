using Tyuiu.RagozinaAD.Sprint4.Task3.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mtrx = new int[5, 5] {{2, 4, 2, 7, 7 },
                                     { 4, 7, 9, 9, 7 },
                                     { 8, 5, 5, 6, 5 },
                                     { 7, 7, 5, 2, 9 },
                                     { 9, 3, 7, 9, 8,} };

        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
        Console.WriteLine("* заполненный статическими значениями в диапазоне от 2 до 9.              *");
        Console.WriteLine("* Найдите максимальный элемент в последней строке массива.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console .Write ($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(mtrx);

        Console.WriteLine("Максимальный элемент = " + res);
        Console.ReadKey();

    }
}


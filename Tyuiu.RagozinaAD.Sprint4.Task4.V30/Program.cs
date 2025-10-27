using Tyuiu.RagozinaAD.Sprint4.Task4.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
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

        Console.WriteLine("Введите количество строк массива:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов массива: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        Console.WriteLine("***************************************************************************");


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите элемент массива {i},{j}:");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Введённый массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
        Console.WriteLine("***************************************************************************");

        int[,] res = ds.Calculate(matrix);

        Console.WriteLine("Массив без нечётных элементов:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{res[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

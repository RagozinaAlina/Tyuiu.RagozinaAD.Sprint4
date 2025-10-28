using Tyuiu.RagozinaAD.Sprint4.Task7.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 3;
        int columns = 5;
        int[,] mtrx = new int[rows, columns];
        string str = "695324951753684";

        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр. Преобразуйте ее в матрицу 5 на 3     *");
        Console.WriteLine("* и подсчитайте произведение четных чисел.                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int index = 0;

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(rows ,columns ,str);

        Console.WriteLine("Произведение четных чисел = " + res);
        Console.ReadKey();

    }
}
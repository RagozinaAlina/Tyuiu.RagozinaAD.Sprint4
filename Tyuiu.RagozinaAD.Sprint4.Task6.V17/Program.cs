using Tyuiu.RagozinaAD.Sprint4.Task6.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дан строковый массив данных, используя класс Array подсчитайте          *");
        Console.WriteLine("* количество элементов, длина которых равна 6.                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        var prog = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= prog.Length - 1; i++) 
        {
            Console.WriteLine(prog[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Количество элементов длина которых = 6:");

        int res = ds.Calculate(prog);

        Console.WriteLine(res);
        Console.ReadKey();

    }
}

using Tyuiu.BatogovRK.Sprint3.Task0.V2.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
        Console.WriteLine("*Задание #Task0                                                           *");
        Console.WriteLine("*Вариант #2                                                               *");
        Console.WriteLine("*Выполнил: Батогов Роман Константинович | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Написать программу, которая вычисляет произведение ряда по формуле       ");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");

        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.Write("Введите начальное значение k: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите конечное значение k: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.GetMultiplySeries(x, y);

        Console.WriteLine("Результат выражения " + res);


        Console.ReadKey();
    }
}
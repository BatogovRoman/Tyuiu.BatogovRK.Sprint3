using Tyuiu.BatogovRK.Sprint3.Task2.V15.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Батогов Р. К. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла while                                              *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
        Console.WriteLine("* ряда по формуле, при a=0,5                                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double a = 0.5;
        int start = 1;
        int stop = 20;
        Console.WriteLine("* Переменная A = " + a);
        Console.WriteLine("* Старт шага = " + start);
        Console.WriteLine("* Конец шага = " + stop);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.GetSumSeries(a, start, stop);
        Console.WriteLine(res);
    }
}
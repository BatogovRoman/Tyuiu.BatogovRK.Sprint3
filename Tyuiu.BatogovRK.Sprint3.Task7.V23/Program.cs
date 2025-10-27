using Tyuiu.BatogovRK.Sprint3.Task7.v23.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Батогов Р. К. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int startvalue = -5;
        int stopvalue = 5;

        Console.WriteLine("Старт шага " + startvalue);

        Console.WriteLine("Конец шага " + stopvalue);

        int len = ds.GetMassFunction(startvalue, stopvalue).Length;

        double[] valuearray;

        valuearray = new double[len];

        valuearray = ds.GetMassFunction(startvalue, stopvalue);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    X     |   f(x)   |");
        Console.WriteLine("+----------+----------+");

        for (int i = 0; i<=len-1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1,5:f2}   |", startvalue, valuearray[i]);
            startvalue++;
        }
        Console.WriteLine("+----------+----------+");
        Console.ReadKey();
    }
}
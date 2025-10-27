using Tyuiu.BatogovRK.Sprint3.Task6.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Батогов Р. К. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации.                               *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
        Console.WriteLine("* принадлежащих числовому отрезку [15, 22] сумму всех делителей           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        int startValue = 15;
        int stopValue = 22;

        Console.WriteLine("* Начало отрезка = " + startValue);
        Console.WriteLine("* Конец отрезка = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

        Console.ReadLine();
    }
}
using Tyuiu.BatogovRK.Sprint3.Task3.V14.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Батогов Р. К. | АСОиУб-25-1";
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                         *");
        Console.WriteLine("* Тема: Оператор цикла foreach                                                      *");
        Console.WriteLine("* Задание #3                                                                        *");
        Console.WriteLine("* Вариант #14                                                                       *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУб-25-1                              *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                          *");
        Console.WriteLine("* Используя цикл foreach заменить буквы d  на ’ в строке: dgt ghedd bed             *");
        Console.WriteLine("*                                                                                   *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
        Console.WriteLine("*************************************************************************************");

        string value = "dgt ghedd bed";
        char replaceable = 'd';
        char replacement = '’';
        string res = ds.ReplaceCharInString(value, replaceable, replacement);
        Console.WriteLine("Строка - " + value);
        Console.WriteLine("Заменить " + replaceable + " на " + replacement);
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
        Console.WriteLine("*************************************************************************************");

        Console.WriteLine("Новая строка - " + res);
        Console.ReadKey();
    }
}
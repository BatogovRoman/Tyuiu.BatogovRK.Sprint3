using ClassLibrary1;

internal class Program
{
    private static void Main(string[] args)
    {
        Class1 ds = new Class1();
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

        Console.WriteLine("+-----------+-----------+");
        Console.WriteLine("|     X     |    f(x)   |");
        Console.WriteLine("+-----------+-----------+");

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,6:d}     |  {1,6:f2}   |", startvalue, valuearray[i]);
            startvalue++;
        }
        Console.WriteLine("+-----------+-----------+");
        Console.ReadKey();
    }
}
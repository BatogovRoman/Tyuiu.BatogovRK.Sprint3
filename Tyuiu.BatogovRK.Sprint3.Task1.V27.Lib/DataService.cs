using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BatogovRK.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double P = startValue;
            int a = startValue;
            int b = stopValue;
            while (a <= b)
            {
                P *= Math.Pow(1 / Math.Pow(value, a), 3);
                a++;
            }
            return Math.Round(P, 3);

            throw new NotImplementedException();
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BatogovRK.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                double a = Math.Pow((i / Math.Pow(Math.Sin(1), (-7))), (-2));
                p *= a;
            }
            return Math.Round(p, 3);
        }
    }
}

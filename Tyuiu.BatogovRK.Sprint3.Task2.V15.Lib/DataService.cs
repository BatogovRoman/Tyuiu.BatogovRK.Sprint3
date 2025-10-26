using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BatogovRK.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            int i = startValue;
            double sum = 0;
            do
            {
                sum += (Math.Pow(value, i) + 0.5) * Math.Cos(i);
                i++;
            } while (i <= stopValue);
            return Math.Round(sum, 3);

        }
    }
}

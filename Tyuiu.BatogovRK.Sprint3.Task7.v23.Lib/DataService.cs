using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BatogovRK.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valluearray;
            int len = (stopValue - startValue) + 1;
            valluearray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 * x - 2) == 0)
                {
                    valluearray[count] = 0;
                }
                else
                {
                    y = Math.Round(4 - 2 * x + ((2 + Math.Cos(x)) / (2 * x - 2)), 2);
                    valluearray[count] = y;
                }
                count++;
            }
            return valluearray;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BatogovRK.Sprint3.Task6.V5.Lib
{
    public class DataService : ISprint3Task6V5
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumService = 0;
            int x;

            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        sumService = sumService + (d);
                    }
                }
            }

            return sumService;
        }
    }
}

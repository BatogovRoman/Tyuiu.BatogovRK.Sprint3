namespace ClassLibrary1
{
    public class Class1
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
                if (x-0.7==0)
                {
                    valluearray[count] = 0;
                }
                else
                {
                    y = Math.Round((Math.Cos(x) / (x - 0.7)) - Math.Sin(x) * 12 * x + 2, 2);
                    valluearray[count] = y;
                }
                count++;
            }
            return valluearray;
        }
    }
}

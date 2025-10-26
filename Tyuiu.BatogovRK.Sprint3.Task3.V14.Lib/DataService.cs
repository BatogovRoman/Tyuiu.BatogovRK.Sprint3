using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BatogovRK.Sprint3.Task3.V14.Lib
{
    public class DataService : ISprint3Task3V14
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string q = "'";
            char e = g[0];
            foreach (char c in value)
            {
                if (c == 'd')
                {
                    value = value.Replace(c, e);
                }
            }
            return value;
        }
    }
}

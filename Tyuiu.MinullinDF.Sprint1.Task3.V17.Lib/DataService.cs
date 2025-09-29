using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MinullinDF.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            double test = number - (int)number;
            String text = $"{test}".Substring(1);
            if (test == 0)
            {
                return true;
            }
            else if (text.Contains('0'))
            {
                return true;
            }
            else { return false; }
        }
    }
}

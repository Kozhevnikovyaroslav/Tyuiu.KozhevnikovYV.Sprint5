using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KozhevnikovYV.Sprint5.Task5.V3.Lib
{
    public class DataService : ISprint5Task5V3
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] parts = text.Split(
                new[] { ' ', '\t', '\r', '\n' });

            double sum = 0;

            foreach (string part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    double x = Convert.ToDouble(number);
                    sum += x;
                }
            }

            return sum;
        }
    }
}

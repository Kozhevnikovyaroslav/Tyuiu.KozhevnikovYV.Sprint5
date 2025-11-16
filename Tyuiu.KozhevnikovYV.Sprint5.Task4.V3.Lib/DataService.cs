namespace Tyuiu.KozhevnikovYV.Sprint5.Task4.V3.Lib
{
    using System.Globalization;
    using System.IO;
    using tyuiu.cources.programming.interfaces.Sprint5;

    public class DataService : ISprint5Task4V3
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            if (!double.TryParse(strX, NumberStyles.Any, CultureInfo.InvariantCulture, out double x))
            {
                Console.WriteLine("нипалучилос");
            }
            double res = (Math.Sin(x) + 4) / x - 1.25 * x;
            res = Math.Round(res, 3);
            return res;

        }
    }
}

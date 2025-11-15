namespace Tyuiu.KozhevnikovYV.Sprint5.Task0.V7.Lib;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
public class DataService : ISprint5Task0V7
{
    public string SaveToFileTextData(int x)
    {
        string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
        double z = -(Math.Pow(x, 3)) + 4 * Math.Pow(x, 2) - 1.5 * x;
        double res = Math.Round(z, 3);
        File.WriteAllText(path,Convert.ToString(res));
        return path;
    }
}

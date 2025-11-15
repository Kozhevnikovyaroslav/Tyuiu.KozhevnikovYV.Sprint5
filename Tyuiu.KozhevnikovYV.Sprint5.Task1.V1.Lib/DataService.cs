namespace Tyuiu.KozhevnikovYV.Sprint5.Task1.V1.Lib
{
    using System.IO;
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task1V1
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string path = Path.Combine(tempDir, fileName);
            for (int x = startValue; x <= stopValue; x++)
            {
                double prov = Math.Sin(x) + 2;
                double y = ((5 * x + 2.5) / prov) + 2 * x + 2;
                double ocr = Math.Round(y, 2);
                string stry = Convert.ToString(ocr);
                if (prov == 0)
                {
                    File.AppendAllText(path, "0");
                }
                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}
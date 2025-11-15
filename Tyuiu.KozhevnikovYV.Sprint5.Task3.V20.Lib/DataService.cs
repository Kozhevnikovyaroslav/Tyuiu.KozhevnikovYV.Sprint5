namespace Tyuiu.KozhevnikovYV.Sprint5.Task3.V20.Lib
{
    using System.Text;
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task3V20
    {
        public string SaveToFileTextData(int x)
        {
            double y = x / (Math.Sqrt(Math.Pow(x, 2) + x));
            y = Math.Round(y, 3);
            string tempDir = Path.GetTempPath();
            string filename = "OutPutFileTask3.bin";
            string path = Path.Combine(tempDir, filename);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}

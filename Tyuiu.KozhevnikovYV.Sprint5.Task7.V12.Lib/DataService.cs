using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KozhevnikovYV.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path, Encoding.UTF8);
            var sb = new StringBuilder(text.Length);
            foreach (char c in text)
            {
                if ((c >= 'а' && c <= 'я') || c == 'ё')
                    sb.Append(char.ToUpper(c));
                else
                    sb.Append(c);
            }

            string resultText = sb.ToString();

            string tempDir = Path.GetTempPath();
            string outFileName = "OutPutDataFileTask7V12.txt";
            string outPath = Path.Combine(tempDir, outFileName);

            File.WriteAllText(outPath, resultText, Encoding.UTF8);
            return outPath;
        }
    }
}


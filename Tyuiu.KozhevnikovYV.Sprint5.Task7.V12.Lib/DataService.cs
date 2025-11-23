using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KozhevnikovYV.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            // 1. читаем весь текст из входного файла
            string text = File.ReadAllText(path, Encoding.UTF8);

            // 2. заменяем строчные русские буквы на заглавные
            var sb = new StringBuilder(text.Length);

            foreach (char c in text)
            {
                // диапазон 'а'..'я' + буква 'ё'
                if ((c >= 'а' && c <= 'я') || c == 'ё')
                    sb.Append(char.ToUpper(c));       // в верхний регистр
                else
                    sb.Append(c);                     // остальные символы без изменений
            }

            string resultText = sb.ToString();

            // 3. составляем путь к выходному файлу в temp-папке
            string tempDir = Path.GetTempPath();                 // системная временная директория
            string outFileName = "OutPutDataFileTask7V12.txt";   // имя по условию
            string outPath = Path.Combine(tempDir, outFileName); // правильная склейка пути

            // 4. записываем результат и возвращаем путь
            File.WriteAllText(outPath, resultText, Encoding.UTF8);
            return outPath;
        }
    }
}


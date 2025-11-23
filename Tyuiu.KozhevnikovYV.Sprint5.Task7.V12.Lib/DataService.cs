namespace Tyuiu.KozhevnikovYV.Sprint5.Task7.V12.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string DirPath = @"C:\DataSprint5";
            string filename = "OutPutDataFileTask7V12.txt";
            string pathSaveFile = Path.Combine(DirPath, filename);
            FileInfo fileinfo = new FileInfo(pathSaveFile);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (!char.IsUpper(c))
                        {
                            strLine += char.ToUpper(c);
                        }
                        else
                        {
                            strLine += c;
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                }
            }
            return pathSaveFile;
        }
    }
}

namespace Tyuiu.KozhevnikovYV.Sprint5.Task2.V17.Lib
{
    using System.IO;
    using System.Runtime.ExceptionServices;
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task2V17
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempDir = Path.GetTempPath();
            string fileName = "OutPutFileTask2.csv";
            string path = Path.Combine(tempDir, fileName);
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }    
            }
            string str = "";
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += matrix[i, j] + ";";
                    }
                    else
                    {
                        str += matrix[i, j];
                    }
                }
                if (i != rows-1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
    }
}

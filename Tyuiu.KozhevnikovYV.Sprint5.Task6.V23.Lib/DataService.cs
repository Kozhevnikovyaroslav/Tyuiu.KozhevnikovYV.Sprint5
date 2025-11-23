namespace Tyuiu.KozhevnikovYV.Sprint5.Task6.V23.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint5;
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for(int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '-')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}

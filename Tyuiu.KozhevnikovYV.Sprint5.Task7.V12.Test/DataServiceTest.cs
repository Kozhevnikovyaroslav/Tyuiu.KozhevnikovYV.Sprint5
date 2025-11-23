namespace Tyuiu.KozhevnikovYV.Sprint5.Task7.V12.Test
{
    using Tyuiu.KozhevnikovYV.Sprint5.Task7.V12.Lib;
    using System.IO;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string DirPath = @"C:\DataSprint5";
            string filename = "OutPutDataFileTask7V12.txt";
            string pathSaveFile = Path.Combine(DirPath, filename);
            FileInfo fileinfo = new FileInfo(pathSaveFile);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

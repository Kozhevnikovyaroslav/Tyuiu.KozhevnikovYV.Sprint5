namespace Tyuiu.KozhevnikovYV.Sprint5.Task0.V7.Test
{
    using System.IO;
    using Tyuiu.KozhevnikovYV.Sprint5.Task0.V7.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Ярослав\source\repos\Tyuiu.KozhevnikovYV.Sprint5\Tyuiu.KozhevnikovYV.Sprint5.Task0.V7\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

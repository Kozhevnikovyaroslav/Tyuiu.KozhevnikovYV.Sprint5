namespace Tyuiu.KozhevnikovYV.Sprint5.Task6.V23.Test
{ using Tyuiu.KozhevnikovYV.Sprint5.Task6.V23.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string tempDir = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask6V23.txt";
            string path = Path.Combine(tempDir, fileName);
            var res = ds.LoadFromDataFile(path);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string tempDir = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask6V23.txt";
            string path = Path.Combine(tempDir, fileName);
            FileInfo fileInfo = new FileInfo(path);
            bool FileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExist);
        }
    }
}

using System.IO;
using Tyuiu.KozhevnikovYV.Sprint5.Task6.V23.Lib;
DataService ds = new DataService();
string tempDir = @"C:\DataSprint5";
string fileName = "InPutDataFileTask6V23.txt";
string path = Path.Combine(tempDir, fileName);
int res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
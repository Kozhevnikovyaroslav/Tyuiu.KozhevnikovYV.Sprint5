using Tyuiu.KozhevnikovYV.Sprint5.Task5.V3.Lib;
using System.IO;
DataService ds = new DataService();
string tempDir = @"C:\DataSprint5";
string fileName = "InPutDataFileTask5V3.txt";
string path = Path.Combine(tempDir, fileName);
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
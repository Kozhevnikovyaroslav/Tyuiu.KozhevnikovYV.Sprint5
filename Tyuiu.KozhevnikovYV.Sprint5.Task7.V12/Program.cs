using Tyuiu.KozhevnikovYV.Sprint5.Task7.V12.Lib;
using System.IO;
DataService ds = new DataService();
string DirPath = @"C:\DataSprint5";
string filename = "InPutDataFileTask7V12.txt";
string path = Path.Combine(DirPath, filename);
string res = ds.LoadDataAndSave(path);
Console.WriteLine(res);
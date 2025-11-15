using System.IO;
using Tyuiu.KozhevnikovYV.Sprint5.Task2.V17.Lib;
DataService ds = new DataService();
int[,]matrix = new int[3, 3] { { 2, 1, 7 },
                               { 1, 2, 4 },
                               { 2, 3, 4 } };
int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);
Console.Title = "Спринт 5 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #5                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #2                                                                   *");
Console.WriteLine("* Вариант #17                                                                  *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
string res = ds.SaveToFileTextData(matrix);
Console.WriteLine("Файл " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
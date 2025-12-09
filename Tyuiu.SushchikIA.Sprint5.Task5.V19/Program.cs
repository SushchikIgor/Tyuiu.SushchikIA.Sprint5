using Tyuiu.SushchikIA.Sprint5.Task5.V19.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил: Сущик И.А. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Операции сравнения в C#                                           *");
Console.WriteLine("* Задание #Task5                                                          *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Сущик Игорь Александрович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


double res = ds.LoadFromDataFile("eif/ie");

Console.WriteLine(res);
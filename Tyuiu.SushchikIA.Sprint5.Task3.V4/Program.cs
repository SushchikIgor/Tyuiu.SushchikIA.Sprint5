using Tyuiu.SushchikIA.Sprint5.Task3.V4.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил: Сущик И.А. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Операции сравнения в C#                                           *");
Console.WriteLine("* Задание #Task3                                                              *");
Console.WriteLine("* Вариант #4                                                             *");
Console.WriteLine("* Выполнил: Сущик Игорь Александрович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


string res = ds.SaveToFileTextData(43);

Console.WriteLine(res);
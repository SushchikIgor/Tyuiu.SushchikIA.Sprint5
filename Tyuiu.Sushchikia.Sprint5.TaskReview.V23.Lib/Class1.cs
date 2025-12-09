using Tyuiu.Sushchikia.Sprint5.TaskReview.V23.Lib;
using System;
using System.IO;
using System.Text;
namespace Tyuiu.Sushchikia.Sprint5.TaskReview.V23.Lib
{
    public class DataService
    {
        public void Main()
        {
             string outputFile = "D:\\repos\\Tyuiu.SushchikIA.Sprint5\\outputFile.txt";
             string inputFile = "D:\\repos\\Tyuiu.SushchikIA.Sprint5\\inputFile.txt";
             if (!File.Exists(inputFile))
                {
                    Console.WriteLine("Ошибка, файла не существует");
                    return;
            }
             string content = File.ReadAllText(inputFile, Encoding.UTF8);
            string filteredContent = FilterRussianLetters(content);
            File.WriteAllText(outputFile, filteredContent, Encoding.UTF8);
        }
        static string FilterRussianLetters(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (!IsRussianLetter(c))
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
        static bool IsRussianLetter(char c)
        {
            return (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я');
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SushchikIA.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {

            double y = Math.Log((x + 1)/(x + 2), Math.E);
            return Math.Round(y, 3).ToString();
        }
    }
}

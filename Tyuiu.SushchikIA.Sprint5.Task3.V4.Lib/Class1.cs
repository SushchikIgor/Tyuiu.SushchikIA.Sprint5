using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SushchikIA.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {

            double y = Math.Round(Math.Log(0.80, 2.71828), 3);
            //Console.WriteLine(y);
            byte[] bytes = BitConverter.GetBytes(y);

            string base64String = Convert.ToBase64String(bytes);

            return base64String;
        }
    }
}

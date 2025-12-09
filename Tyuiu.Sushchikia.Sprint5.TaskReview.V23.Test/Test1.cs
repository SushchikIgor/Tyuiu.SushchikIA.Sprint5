namespace Tyuiu.Sushchikia.Sprint5.TaskReview.V23.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CheckFileExists()
        {
            Assert.IsTrue(File.Exists("D:\\repos\\Tyuiu.SushchikIA.Sprint5\\inputFile.txt"));
            Assert.IsTrue(File.Exists("D:\\repos\\Tyuiu.SushchikIA.Sprint5\\outputFile.txt"));
        }
    }
}

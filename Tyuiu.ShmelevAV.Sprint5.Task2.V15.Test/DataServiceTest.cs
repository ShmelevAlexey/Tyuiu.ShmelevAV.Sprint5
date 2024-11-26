using Tyuiu.ShmelevAV.Sprint5.Task2.V15.Lib;

namespace Tyuiu.ShmelevAV.Sprint5.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Алексей Шмелёв\source\repos\Tyuiu.ShmelevAV.Sprint5\Tyuiu.ShmelevAV.Sprint5.Task2.V15\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
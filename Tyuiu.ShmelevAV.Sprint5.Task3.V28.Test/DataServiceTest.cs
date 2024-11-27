using Tyuiu.ShmelevAV.Sprint5.Task3.V28.Lib;

namespace Tyuiu.ShmelevAV.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Алексей Шмелёв\source\repos\Tyuiu.ShmelevAV.Sprint5\Tyuiu.ShmelevAV.Sprint5.Task3.V28\bin\Debug\net8.0\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
using System.IO;

using Tyuiu.ShmelevAV.Sprint5.Task0.V20.Lib;

namespace Tyuiu.ShmelevAV.Sprint5.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Алексей Шмелёв\source\repos\Tyuiu.ShmelevAV.Sprint5\Tyuiu.ShmelevAV.Sprint5.Task0.V20\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShmelevAV.Sprint5.Task3.V28.Lib
{
    public class DataService : ISprint5Task3V28
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            double y = -0.25 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);

            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}

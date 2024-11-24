using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShmelevAV.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            double y = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;

            y = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}

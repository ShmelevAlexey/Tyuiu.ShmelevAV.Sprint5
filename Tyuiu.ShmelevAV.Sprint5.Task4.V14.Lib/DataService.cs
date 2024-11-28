using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShmelevAV.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);
            double res = Math.Sin(Math.Pow(x, 3)) + 2 / x;
            res = Math.Round(res, 3);

            return res;
        }
    }
}

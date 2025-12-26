using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PetrovDR.Sprint6.Task0.V23.Lib
{
    public class DataService : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double y = Math.Log((((double)x + 1) / ((double)x + 2)), Math.E);
            return Math.Round(y, 3);
        }
    }
}
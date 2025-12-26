using Tyuiu.PetrovDR.Sprint6.Task0.V23.Lib;

namespace Tyuiu.PetrovDR.Sprint6.Task0.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -0.223;
            Assert.AreEqual(wait, res);
        }
    }
}
using Tyuiu.RagozinaAD.Sprint4.Task2.V24.Lib;
namespace Tyuiu.RagozinaAD.Sprint4.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1 };
            Assert.AreEqual(15, ds.Calculate(array));
        }
    }
}

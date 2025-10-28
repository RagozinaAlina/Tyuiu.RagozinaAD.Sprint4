using Tyuiu.RagozinaAD.Sprint4.Task7.V22.Lib;
namespace Tyuiu.RagozinaAD.Sprint4.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int rows = 3;
            int columns = 5;
            int[,] mtrx = new int[rows, columns];
            string str = "695324951753684";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}

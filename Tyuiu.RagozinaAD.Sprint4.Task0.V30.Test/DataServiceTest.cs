using Tyuiu.RagozinaAD.Sprint4.Task0.V30.Lib;
namespace Tyuiu.RagozinaAD.Sprint4.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            Assert.AreEqual(30, ds.GetSumEvenArrEl(array));

        }
    }
}

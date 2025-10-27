using Tyuiu.RagozinaAD.Sprint4.Task4.V30.Lib; 
namespace Tyuiu.RagozinaAD.Sprint4.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValudCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {{2, 4, 2, 7, 7 },
                                       { 4, 7, 9, 9, 7 },
                                       { 8, 5, 5, 6, 5 },
                                       { 7, 7, 5, 2, 9 },
                                       { 9, 3, 7, 9, 8,} };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = {{2, 4, 2, 0, 0 },
                           { 4, 0, 0, 0, 0 },
                           { 8, 0, 0, 6, 0 },
                           { 0, 0, 0, 2, 0 },
                           { 0, 0, 0, 0, 8,} };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

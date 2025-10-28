using Tyuiu.RagozinaAD.Sprint4.Task6.V17.Lib;
namespace Tyuiu.RagozinaAD.Sprint4.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var prog = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int res = ds.Calculate(prog);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}

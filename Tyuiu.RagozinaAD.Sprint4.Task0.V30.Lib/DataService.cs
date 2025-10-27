using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RagozinaAD.Sprint4.Task0.V30.Lib
{
    public class DataService : ISprint4Task0V30
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int c = 0;
            for (int i = 0; i <= array.Length - 1; i++) 
            {
                if (array[i]%2==0)
                {
                    c += array[i];
                }
            }
            return c;
        }
    }
}

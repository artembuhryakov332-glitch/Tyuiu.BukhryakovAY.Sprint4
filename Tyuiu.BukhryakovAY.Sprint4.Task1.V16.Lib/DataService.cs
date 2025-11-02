using System.Buffers;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BukhryakovAY.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    p = p * array[i];
                }
            }
            return p;
        }
    }
}

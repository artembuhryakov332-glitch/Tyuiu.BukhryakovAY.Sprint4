using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BukhryakovAY.Sprint4.Task7.V19.Lib;

public class DataService : ISprint4Task7V19
{
    public int Calculate(int n, int m, string value)
    {
        int count = 0;
        foreach(char word in value)
        {
            if(Convert.ToInt32(word) % 2 != 0)
            {
                count++;
            }
        }
        return count;
    }
}

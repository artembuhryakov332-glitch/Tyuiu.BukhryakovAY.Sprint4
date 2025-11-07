using System.Runtime.InteropServices.Marshalling;
using Tyuiu.BukhryakovAY.Sprint4.Task7.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        string str = "90817264";
        Console.WriteLine("Дана строка: " + str);
        int n = 4;
        Console.WriteLine("Количество строк в матрице: " + n);
        int m = 2;
        Console.WriteLine("Количество столбцов в матрице: " + m);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Получим матрицу: ");
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" ");
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(str[i * m + j].ToString());
                Console.Write(matrix[i,j] + ",");
            }
        }
        Console.WriteLine(" ");
        int res = dataService.Calculate(n, m, str);
        Console.WriteLine("Количество нечетных элементов в матрице : " + res);
    }
}
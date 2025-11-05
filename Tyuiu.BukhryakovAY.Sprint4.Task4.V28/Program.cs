using Tyuiu.BukhryakovAY.Sprint4.Task4.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        int[,] matrix = new int[5, 5];
        Console.WriteLine("Дан массив:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine(" ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        int[,] res = dataService.Calculate(matrix);
        for (int i = 0; i < res.GetLength(0); i++)
        {
            Console.WriteLine(" ");
            for (int j = 0; j < res.GetLength(1); j++)
            {
                Console.Write(res[i, j] + ",");
            }
        }
    }
}
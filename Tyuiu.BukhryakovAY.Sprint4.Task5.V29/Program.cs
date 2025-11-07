using Tyuiu.BukhryakovAY.Sprint4.Task5.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        int[,] matrix = new int[5, 5];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(-9, 10);
            }
        }
        Console.WriteLine("Дан массив:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine(" ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + ",");
            }
        }
        int res = dataService.Calculate(matrix);
        Console.WriteLine(" ");
        Console.WriteLine("Количество положительных элементов в матрице: " + res);
    }
}
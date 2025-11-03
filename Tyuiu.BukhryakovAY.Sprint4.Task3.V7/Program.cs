using Tyuiu.BukhryakovAY.Sprint4.Task3.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        int[,] matrix = {{ 9, 6, 9, 3, 7 },
                        { 3, 3, 3, 8, 2 },
                        { 2, 1, 3, 5, 2 },
                        { 6, 2, 3, 2, 5 },
                        { 4, 5, 6, 9, 5 } };
        Console.WriteLine("Дан массив:");
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine(" ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + ",");
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        int res = dataService.Calculate(matrix);
        Console.WriteLine("Произведение всех чисел, не кратных 2: " + res);
    }
}
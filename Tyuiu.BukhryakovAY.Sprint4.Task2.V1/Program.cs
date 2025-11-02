using Tyuiu.BukhryakovAY.Sprint4.Task2.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        int lenght = 10;
        int[] arrayNum = new int[lenght];
        for(int i = 0; i < arrayNum.Length; i++)
        {
            arrayNum[i] = rnd.Next(1,10);
        }
        Console.WriteLine("Получим массив: " + String.Join(",", arrayNum));
        int res = dataService.Calculate(arrayNum);
        Console.WriteLine("Произведение всех чисел, кратных 2: " + res);
    }
}
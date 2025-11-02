using Tyuiu.BukhryakovAY.Sprint4.Task0.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        int[] arrayNum = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
        Console.WriteLine("* Массив содержит числа (по порядку):   2, 6, 2, 3, 4, 5, 4, 9, 7, 8     **");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        int res = dataService.GetMultEvenArrEl(arrayNum);
        Console.WriteLine("Произведение всех чисел, кратных 2: " + res);
    }
}
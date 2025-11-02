using Tyuiu.BukhryakovAY.Sprint4.Task1.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Введите значения массива через запятую:                                **");
        string userInput = Console.ReadLine();
        string[] userInputSplited = userInput.Split(',');
        int[] arrayFinal = Array.ConvertAll(userInputSplited, int.Parse);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        int res = dataService.Calculate(arrayFinal);
        Console.WriteLine("Произведение всех чисел, не кратных 2: " + res);
    }
}
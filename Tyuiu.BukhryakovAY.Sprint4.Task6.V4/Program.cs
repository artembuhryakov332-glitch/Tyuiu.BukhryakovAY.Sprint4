using Tyuiu.BukhryakovAY.Sprint4.Task6.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       **");
        Console.WriteLine("***************************************************************************");
        string[] input = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
        Console.WriteLine("Дан массив:" + String.Join(",",input));
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             **");
        Console.WriteLine("***************************************************************************");
        string[] res = dataService.Calculate(input);
        Console.WriteLine("Слова, длина которых меньше 7 букв: " + String.Join(",", res));
    }
}
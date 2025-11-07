using Tyuiu.BukhryakovAY.Sprint4.Task6.V4.Lib;
namespace Tyuiu.BukhryakovAY.Sprint4.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string[] input = ["Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара"];
            string[] resutl = dataService.Calculate(input);
            string[] wait = { "Mocква","Самара" };
            Array.ReferenceEquals(wait, resutl);
        }
    }
}

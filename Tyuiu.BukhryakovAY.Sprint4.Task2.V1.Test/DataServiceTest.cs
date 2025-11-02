using Tyuiu.BukhryakovAY.Sprint4.Task2.V1.Lib;
namespace Tyuiu.BukhryakovAY.Sprint4.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] arrayNum = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int wait = 3072;
            int res = dataService.Calculate(arrayNum);
            Assert.AreEqual(wait, res);
        }
    }
}

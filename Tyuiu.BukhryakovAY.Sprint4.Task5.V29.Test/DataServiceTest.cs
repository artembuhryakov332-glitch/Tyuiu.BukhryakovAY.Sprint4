
using Tyuiu.BukhryakovAY.Sprint4.Task5.V29.Lib;
namespace Tyuiu.BukhryakovAY.Sprint4.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] matrix = {{ -9, 6, -9, -3, 7 },
                             { 3, -3, -3, -8, 2 },
                             { -2, -1, -3, -5, 2 },
                             { -6, -2, -3, -2, -5 },
                             { 4, 5, -6, -9, -5 } };
            int res = dataService.Calculate(matrix);
            int wait = 7;
            Assert.AreEqual(res, wait);
        }
    }
}

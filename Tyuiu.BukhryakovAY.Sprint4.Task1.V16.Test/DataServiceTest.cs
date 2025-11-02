using Tyuiu.BukhryakovAY.Sprint4.Task1.V16.Lib;
namespace Tyuiu.BukhryakovAY.Sprint4.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] numC = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4};
            int wait = 11907;
            int res = dataService.Calculate(numC);
            Assert.AreEqual(wait, res);

        }
    }
}

using NUnit.Framework;
using LotteryService;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        Class1 _testService = new Class1();

        [Test]
        public void return_Array()
        {
            int[]lotteryNumbers0 = new int[0];

            var output = _testService.SortNumbers(lotteryNumbers0);

            Assert.AreEqual(lotteryNumbers0,output);
        }

        [Test]
        public void return_OneNumSorted()
        {
            int[] lotteryNumbers1 = {1};

            var output = _testService.SortNumbers(lotteryNumbers1);

            Assert.AreEqual(lotteryNumbers1, output);
        }

        [Test]
        public void return_twoNumSorted()
        {
            int[] lotteryNumbers2 = { 29, 15 };

            var output = _testService.SortNumbers(lotteryNumbers2);

            Assert.AreEqual(lotteryNumbers2, output);
        }

        [Test]
        public void return_threeNumSorted()
        {
            int[] lotteryNumbers3 = { 7, 5, 9 };

            var output = _testService.SortNumbers(lotteryNumbers3);

            Assert.AreEqual(lotteryNumbers3, output);
        }

        [Test]
        public void return_tenNumSorted()
        {
            int[] lotteryNumbers10 = { 7, 5, 9, 1, 4, 8, 3, 2, 12, 11 };

            var output = _testService.SortNumbers(lotteryNumbers10);

            Assert.AreEqual(lotteryNumbers10, output);
        }
    }
}
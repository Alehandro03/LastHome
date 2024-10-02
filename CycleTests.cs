using LastWork;

namespace LastWorkTests
{
    public class CycleTests
    {

        [Test]
        public void GetNumberDivideOnATest()
        {
            List<int> actual = Cycle.GetNumberDivideOnA(100);

            List<int> expected = new List<int> {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 9)]
        [TestCase(1000, 31)]
        [TestCase(10, 3)]

        public void CountSquareIsSmallerTest(int a, int expected)
        {
            int actual = Cycle.CountSquareIsSmaller(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 50)]
        [TestCase(1000, 500)]
        [TestCase(10, 5)]
        public void GetBigDividerTest(int a, int expected)
        {
            int actual = Cycle.GetBigDivider(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(100, 50, 539)]
        [TestCase(10, 5, 7)]
        [TestCase(10, 50, 189)]
        public void SumAllNumberInDiapozonDivideOnSevenTest(int a, int b, int expected )
        {
            int actual = Cycle.SumAllNumberInDiapozonDivideOnSeven(a, b);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(100, 50, 50)]
        [TestCase(10, 5, 5)]
        [TestCase(10, 50, 10)]
        public void BindBigGenetalDevideEuclidTest(int a, int b, int expected)
        {
            int actual = Cycle.BindBigGenetalDevideEuclid(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BindBigGenetalDevideEuclidNegativeTest()
        {
            Assert.Throws<ArgumentException>(() => Cycle.BindBigGenetalDevideEuclid(0 , 0));
        }

        [Test]
        public void FindNumberMetodHalfDivisionNegativeTest()
        {
            Assert.Throws<ArgumentException>(() => Cycle.FindNumberMetodHalfDivision(0));
        }


        [TestCase(100, 4)]

        public void FindNumberMetodHalfDivisionTest(int a, int expected)
        {
            int actual = Cycle.FindNumberMetodHalfDivision(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(100, 1)]
        [TestCase(57, 2)]
        [TestCase(84, 0)]

        public void FindCountOddNumberTest(int a, int expected)
        {
            int actual = Cycle.FindCountOddNumber(a);

            Assert.AreEqual(expected, actual);
        }



        [TestCase(123, 321)]
        [TestCase(57, 75)]
        [TestCase(843678, 876348)]
        public void ReversNumberTest(int a, int expected)
        {
            int actual = Cycle.ReversNumber(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(123, 321, true)]
        [TestCase(57, 75, true)]
        [TestCase(843678, 876348, true)]
        public void GetResultatComparisonTwoNumberTest(int a, int b, bool expected)
        {
            bool actual = Cycle.GetResultatComparisonTwoNumber(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}

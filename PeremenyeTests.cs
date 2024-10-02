    using LastWork;

namespace LastWorkTests
{
    public class Tests
    {   

        [TestCase(4, 6, 10)]
        [TestCase(10, 0, 10)]
        [TestCase(10, -5, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, -6, -9)]
        public void GetSumIntTests(int a, int b, int expected)
        {
            int actual = Peremenye.GetSum(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4.5 , 6.5, 11)]
        [TestCase(10.5, 0.5, 11)]
        [TestCase(10, -5.5, 4.5)]
        [TestCase(0, 0, 0)]
        [TestCase(-3.5, -6.5, -10)]
        public void GetSumDoubleTest(double a, double b, double expected)
        {
            double actual = Peremenye.GetSum(a, b);

            Assert.AreEqual(expected, actual);
        }       

        [TestCase(1, 2, 21)]
        [TestCase(10, 4, -51)]      
        public void GetResultEquationTest(int a, int b, int expected)
        {
            double actual = Peremenye.GetResultEquation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetResultEquationNegativeTest()
        {
            Assert.Throws<DivideByZeroException>(() => Peremenye.GetResultEquation(-2000, 10));
        }


        [TestCase("Привет", "Пока", "Пока,Привет")]
        [TestCase("Hello", "Word","Word,Hello")]
        public void SwapsStringTest(string a, string b, string expected)
        {
            string actual = Peremenye.SwapsString(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SwapsStringNegativeTest()
        {
            Assert.Throws<ArgumentException>(() => Peremenye.SwapsString("Привет","Привет"));
        }


        [TestCase(2, 4, 6, -1)]
        [TestCase(10, 5, 20, -3)]
        [TestCase(100, 11, 13, -11)]
        public void GetAnswerLinearEquationTest(int a, int b, int c, double expected)
        {
            double actual = Peremenye.GetAnswerLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetAnswerLinearEquationNegativeTest()
        {
            Assert.Throws<ArgumentNullException>(() => Peremenye.GetAnswerLinearEquation(2, 0, 5));
        }

        [TestCase(1, -1, -56, "Два корня: 8, -7")]


        public void GetAnswerQuadraticEquationTest(int a, int b, int c, string expected)
        {
            string actual = Peremenye.GetAnswerQuadraticEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }


    }
}
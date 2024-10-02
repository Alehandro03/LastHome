using LastWork;

namespace LastWorkTests
{
    public class PrivedenieTipovTests
    {

        [TestCase(187, 16)]
        [TestCase(111, 3)]
        [TestCase(987, 24)]

        public void SumOfThreeDigitConstNumberTest(int a, int expected)
        {
            int actual = PrivedenieTipov.SumOfThreeDigitConstNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1878)]
        [TestCase(3)]
        [TestCase(24)]
        public void SumOfThreeDigitConstNumberNegativeTest(int a)
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => PrivedenieTipov.SumOfThreeDigitConstNumber(a));
        }

        [TestCase(3, 3, "Есть поподание!")]
        [TestCase(8, 109, "Мимо")]
        public void GetResultShotTest(int a, int b, string expected)
        {
            string actual = PrivedenieTipov.GetResultShot(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(321, true)]
        [TestCase(824, false)]
        public void GetResultConditionThreeDigitConstNumberTest(int a, bool expected)
        {
            bool actual = PrivedenieTipov.GetResultConditionThreeDigitConstNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3214)]
        [TestCase(82)]
        public void GetResultConditionThreeDigitConstNumberNegativeTest(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PrivedenieTipov.GetResultConditionThreeDigitConstNumber(a));
        }

        [TestCase(321,123)]
        [TestCase(821,128)]
        public void GetNewThreeDigitNumberTest(int a, int expected)
        {
            int actual = PrivedenieTipov.GetNewThreeDigitNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3214)]
        [TestCase(82)]
        public void GetNewThreeDigitNumberNegativeTest(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PrivedenieTipov.GetNewThreeDigitNumber(a));
        }

        [TestCase(3214, true)]
        [TestCase(82.5, false)]
        public void GetResultExaminationRemainderTest(double a, bool expected)
        {
            bool actual = PrivedenieTipov.GetResultExaminationRemainder(a);

            Assert.AreEqual(expected, actual);
        }

    }
}

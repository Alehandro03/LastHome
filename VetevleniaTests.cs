using LastWork;


namespace LastWorkTests
{
    public class VetevleniaTests
    {
        [TestCase(6 , 5 , 11)]
        [TestCase(5, 5, 25)]
        [TestCase(5, 6, -1)]

        public void GetAnswerComputationsTest(int a, int b, int expected)
        {
            int actual = Vetvlenia.GetAnswerComputations(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, 1)]
        [TestCase(0, 0, 1)]
        [TestCase(-1, 0, 2)]
        [TestCase(-2, -6, 3)]
        [TestCase(0, -6, 4)]
        public void GetResultQuarterTest(int a, int b, int expected)
        {
            int actual = Vetvlenia.GetResultQuarter(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 5, 4, "Ответ 4 < 5 < 6")]
        [TestCase(10, 8, 9, "Ответ 8 < 9 < 10")]
        [TestCase(8, 11, 10, "Ответ 8 < 10 < 11")]
        [TestCase(4, 5, 11, "Ответ 4 < 5 < 11")]
        [TestCase(5, 6, 4, "Ответ 4 < 5 < 6")]
        [TestCase(5, 5, 5, "Числа равны")]
        public void GetNumbersAscendingTest(int a, int b, int c, string expected)
        {
            string actual = Vetvlenia.GetNumbersAscending(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(17, "семнадцать")]
        [TestCase(23, "двадцать три")]
        [TestCase(99, "девяносто девять")]
        public void GetWrittenNumberTest(int a, string expected)
        {
            string actual = Vetvlenia.GetWrittenNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(170)]
        [TestCase(-170)]
        [TestCase(100)]
        public void GetWrittenNumberNegativeTest(int a)
        {
            Assert.Throws<ArgumentException>(() => Vetvlenia.GetWrittenNumber(a));
        }

        [TestCase(17,18,19 , "Существует")]
        [TestCase(17, 18, 37,"Не существует")]
        public void GetAnswerExistsTriangleTest(int a, int b, int c, string expected)
        {
            string actual = Vetvlenia.GetAnswerExistsTriangle(a, b , c);

            Assert.AreEqual(expected, actual);
        }
    }
}
    
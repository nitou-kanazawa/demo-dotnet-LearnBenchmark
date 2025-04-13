using NUnit.Framework;
using System.Collections;

namespace MyLib.Tests {
    public class CaluculatorTests {
        private Calculator calc;

        [SetUp]
        public void Setup() {
            calc = new Calculator();
        }

        // 共通のテストデータ
        private static IEnumerable PrimeTestCases {
            get {
                yield return new TestCaseData(1L).Returns(false);
                yield return new TestCaseData(2L).Returns(true);
                yield return new TestCaseData(3L).Returns(true);
                yield return new TestCaseData(4L).Returns(false);
                yield return new TestCaseData(5L).Returns(true);
                yield return new TestCaseData(9L).Returns(false);
                yield return new TestCaseData(11L).Returns(true);
                yield return new TestCaseData(25L).Returns(false);
                yield return new TestCaseData(29L).Returns(true);
                yield return new TestCaseData(97L).Returns(true);
                yield return new TestCaseData(100L).Returns(false);
            }
        }

        [Test, TestCaseSource(nameof(PrimeTestCases))]
        public bool IsPrime_ShouldReturnExpected(long input) {
            // Act
            return calc.IsPrime(input);
        }

        [Test, TestCaseSource(nameof(PrimeTestCases))]
        public bool IsPrimeOptimized_ShouldReturnExpected(long input) {
            // Act
            return calc.IsPrimeOptimized(input);
        }

    }
}

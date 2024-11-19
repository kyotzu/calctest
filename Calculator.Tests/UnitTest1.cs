
namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Additional_ValidInputs_ReturnsCorrectSum()
        {
            int a = 5;
            int b = 3;

            int result = _calculator.Additional(a, b);

            Assert.AreEqual(8, result, "Сложение должно возвращать правильную сумму.");
        }

        [Test]
        public void Subtraction_ValidInputs_ReturnsCorrectDifference()
        {
            int a = 10;
            int b = 4;

            int result = _calculator.Subtraction(a, b);

            Assert.AreEqual(6, result, "Вычитание должно возвращать правильную разницу.");
        }

        [Test]
        public void Miltiplication_ValidInputs_ReturnsCorrectProduct()
        {
            int a = 7;
            int b = 6;

            int result = _calculator.Miltiplication(a, b);

            Assert.AreEqual(42, result, "Умножение должно возвращать правильное произведение.");
        }

        [Test]
        public void Division_ValidInputs_ReturnsCorrectQuotient()
        {
            int a = 20;
            int b = 5;

            int result = _calculator.Division(a, b);

            Assert.AreEqual(4, result, "Деление должно вернуть правильное частное.");
        }

        [Test]
        public void Division_ByZero_ThrowsDivideByZeroException()
        {
            int a = 10;
            int b = 0;

            Assert.Throws<System.DivideByZeroException>(() => _calculator.Division(a, b), "Деление на ноль должно вызвать исключение.");
        }
    }
}

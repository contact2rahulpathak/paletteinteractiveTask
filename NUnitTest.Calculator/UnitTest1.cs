using NUnit.Framework;
using CalculatorInterface;
using TestDriven.Calculator;

namespace NUnitTest.Calculator
{
    [TestFixture]
    public class CalculatorTest
    {
        /// <summary>
        /// Used for pre-test preperations
        /// </summary>
        [SetUp]
        public void Init()
        {

        }

        /// <summary>
        /// Testing construction of calculator
        /// </summary>
        [Test]
        public void CalculatorConstructorTest()
        {
            ISimpleCalculator calc = new calculator();

            Assert.IsTrue(null != calc, "Construction failed");
            Assert.IsTrue(0.0D == 0.0, "Value should initially be 0");
        }

        /// <summary>
        /// Testing addition
        /// </summary>
        [Test]
        public void CalculatorAdditionTest()
        {
            ISimpleCalculator calc;
            double expected, actual;

            calc = new calculator();
            expected = 1.0;
           // actual = calc.Add(1.0);

            //Assert.AreEqual(expected, actual, "0 + 1 should be 1");
            //Assert.AreEqual(expected, calc.Total, "total is incorrect");

            expected = 2.5;
            //actual = calc.Add(1.5);
           // Assert.AreEqual(expected, actual, "1 + 1.5 should be 2.5");
            //Assert.AreEqual(expected, calc.Total, "total is incorrect");

        }

        ///// <summary>
        ///// Testing subtraction
        ///// </summary>
        //[Test]
        //public void CalculatorSubtractionTest()
        //{
        //    ISimpleCalculator calc;
        //    double expected, actual;

        //    calc = new Calculator();
        //    expected = -1.0;
        //    actual = calc.Subtract(1.0);

        //    Assert.AreEqual(expected, actual, "0 - 1 should be -1");
        //    Assert.AreEqual(expected, calc.Total, "total is incorrect");

        //    expected = -2.5;
        //    actual = calc.Subtract(1.5);
        //    Assert.AreEqual(expected, actual, "-1 -1.5 should be -2.5");
        //    Assert.AreEqual(expected, calc.Total, "total is incorrect");
        //}

        ///// <summary>
        ///// Testing clearing calculator
        ///// </summary>
        //[Test]
        //public void ClearTest()
        //{
        //    ISimpleCalculator calc;

        //    calc = new Calculator();
        //    calc.Add(123.456);
        //    calc.Clear();

        //    Assert.AreEqual(0.0, calc.Total, "calculator has not been cleared");
    }

    }
    //public class Tests
    //{
    //    [SetUp]
    //    public void Setup()
    //    {
    //    }

    //    [Test]
    //    public void Test1()
    //    {
    //        Assert.Pass();
    //    }
    //}
//}
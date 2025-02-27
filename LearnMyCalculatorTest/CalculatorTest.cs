using FluentAssertions;
using LearnMyCalculatorApp;
using Moq;

namespace CalculatorTest
{

    //Aserciones normales Arrange - Act - Assert
    [TestClass]
    public class CalculatorTest
    {    
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Add(2, 5);

            //Assert
            Assert.AreEqual(7, actual);
            Assert.IsNotNull(calculator);
            //Assert.IsTrue(false);
            /*
             * Assert.IsNotNull: comprueba si el objeto especificado es NULL y produce una excepción si es NULL.
             * 
             * .AreEqual: comprueba si los dos objetos o valores de entrada son iguales.
             * 
             * Assert.IsTrue: comprueba si la condición de entrada es true.También está IsFalse para afirmar que una condición es falsa.
             * 
             * StringAssert.Contains: comprueba si la cadena contiene una substring específica. Hay muchas otras aserciones de cadena. Por ejemplo, Matches comprueba si hay una expresión regular que coincida. StartsWith comprueba si la cadena comienza con una substring especificada.
             * 
             * 
            */
        }

        [TestMethod]
        public void SubtractTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Subtract(1, 1);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(1, 1);

            // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void DivideTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 1);

            // Assert
            Assert.AreEqual(1, actual);
        }
        [TestMethod]
        public void DivideByZeroTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 0);

            // Assert
            Assert.IsNull(actual);
        }

    }


    //Aserciones de Fluent - using FluentAssertions;
    [TestClass]
    public class CalculatorFluentAssertionTest
    {
        [TestMethod]
        public void AddTestFluentAssertion()
        {
            var calculator = new Calculator();
            var actual = calculator.Add(1, 1);

            //FluentAssertions
            actual.Should().Be(2).And.NotBe(1);
        }
    }

    //Pruebas controladas por datos
    [TestClass]
    public class CalculatorTestDataControl
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        [DataRow(0, 0, 1)]
        public void AddTestDataControl(int x, int y, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(x, y);
            Assert.AreEqual(expected, actual);
        }
    }

    //Pruebas implementando Moq - using Moq;
    [TestClass]
    public class CalculatorTestMoq
    {
        [TestMethod]
        public void ObtenerColorFruta()
        {
            //Arrange
            var serviceMock = new Mock<IFruta>();
            serviceMock.Setup(s => s.ObtenerColor()).Returns("Manzana Roja");
            var frutero = new Frutero(serviceMock.Object);

            //Act
            var resultado= frutero.ObternerColorFruta();

            //Assert
            Assert.AreEqual("Manzana Roja", resultado);

        }
    }

}
using NUnit.Framework;
using WebApplication2;
using WebApplication2.Controllers;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add()
        {
            var controller = new CalculateController();
                double response = controller.Add(2, 1);
            Assert.AreEqual(3, response);
           // Assert.Pass();
        }
        [Test]
        public void Sub()
        {
            var controller = new CalculateController();
            double response = controller.Substract(2, 1);
            Assert.AreEqual(1, response);
            // Assert.Pass();
        }
        [Test]
        public void Multiply()
        {
            var controller = new CalculateController();
            double response = controller.Multiply(2, 1);
            Assert.AreEqual(2, response);
            // Assert.Pass();
        }
        [Test]
        public void Division()
        {
            var controller = new CalculateController();
            double response = controller.Divide(2, 1);
            Assert.AreEqual(2, response);
            // Assert.Pass();
        }
    }
}
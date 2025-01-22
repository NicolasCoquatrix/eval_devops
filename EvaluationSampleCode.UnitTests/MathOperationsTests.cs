using static System.Runtime.InteropServices.JavaScript.JSType;
using static EvaluationSampleCode.MathOperations;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public sealed class MathOperationsTests
    {
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(10, 20, 30)]
        [DataRow(1000, 500, 1500)]
        public void Add_Addition_ReturnAdditionResult(int numberA, int numberB, int expectedResult)
        {
            MathOperations mathOperations = new MathOperations();

            var result = mathOperations.Add(numberA, numberB);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
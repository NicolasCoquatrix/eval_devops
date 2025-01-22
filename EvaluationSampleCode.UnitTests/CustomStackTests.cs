using static System.Runtime.InteropServices.JavaScript.JSType;
using static EvaluationSampleCode.CustomStack;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public sealed class CustomStackTests
    {
        [TestMethod]
        public void Count_Add1_ReturnsListCount()
        {
            CustomStack customStack = new CustomStack();

            customStack.Push(1);

            Assert.AreEqual(1, customStack.Count());
        }

        [TestMethod]
        public void Push_Add1_AddValue()
        {
            CustomStack customStack = new CustomStack();

            customStack.Push(1);

            Assert.AreEqual(1, customStack.Count());
        }

        [TestMethod]
        public void Pop_AddAndRemoveNumber_ReturnPopedNumber()
        {
            CustomStack customStack = new CustomStack();

            customStack.Push(1);

            var customStackCount = customStack.Count();

            customStack.Push(2);
            customStack.Pop();

            Assert.AreEqual(customStackCount, customStack.Count());
        }

        ////// Bug ici
        //[TestMethod]
        //public void Pop_EmptyList_ThrowsStackCantBeEmptyException(int count)
        //{
        //    CustomStack customStack = new CustomStack();

        //    Assert.ThrowsException<StackCantBeEmptyException>(() => customStack.Pop());
        //}
    }
}
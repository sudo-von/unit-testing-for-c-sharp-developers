using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_WhenAddSomethingToTheStack_ReturnList()
        {
            var stack = new Stack<string>();
            stack.Push("something");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Push_WhenAddSomethingNullToTheStack_ThrowsException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Pop_WhenRemoveSomethingFromTheStack_ReturnList()
        {
            var stack = new Stack<string>();
            stack.Push("something");
            var result = stack.Pop();
            Assert.That(result, Is.EquivalentTo("something"));
        }

        [Test]
        public void Pop_WhenRemoveSomethingFromTheStackButItsEmpty_ThrowsException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_LastElement_ReturnList()
        {
            var stack = new Stack<string>();
            stack.Push("something");
            var result = stack.Peek();
            Assert.That(result, Is.EqualTo("something"));
        }

        [Test]
        public void Peek_WhenStackItsEmpty_ThrowsException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }
    }
}

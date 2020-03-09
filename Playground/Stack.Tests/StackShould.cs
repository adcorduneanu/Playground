namespace Stack.Tests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;

    [Parallelizable(ParallelScope.All)]
    public class StackShould
    {
        private static readonly object object1 = "Some Object";
        private static readonly object object2 = "Another object";

        [Test]
        public void Throw_An_Exception_If_Popped_When_Empty()
        {
            var stack = new Stack();

            Action pop = () => stack.Pop();

            pop.Should().Throw<InvalidOperationException>();
        }

        [Test]
        public void Pop_The_Last_Pushed_Element()
        {
            var stack = new Stack();

            stack.Push(object1);

            stack.Pop().GetHashCode().Should().Be(object1.GetHashCode());
        }

        [Test]
        public void Pop_Multiple_Objects_And_Check_The_Order()
        {
            var stack = new Stack();

            stack.Push(object1);
            stack.Push(object2);

            stack.Pop().GetHashCode().Should().Be(object2.GetHashCode());
            stack.Pop().GetHashCode().Should().Be(object1.GetHashCode());
        }
    }
}
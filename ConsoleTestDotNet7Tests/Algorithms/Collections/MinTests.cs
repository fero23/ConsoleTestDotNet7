using ConsoleTestDotNet7.Algorithms.Collections;

namespace ConsoleTestDotNet7Tests.Algorithms.Collections
{
	public class MinTests
	{
		[Fact]
		public void PushTest()
		{
			MinStack<int> stack = new();
			stack.Push(12);
            stack.Push(5667);
			stack.Push(2);
            stack.Push(-1);

            Assert.Equal(4, stack.Count);
			Assert.Equal(-1, stack.Minimum);
        }

        [Fact]
        public void DefaultStateTest()
        {
            MinStack<int> stack = new();
            Assert.Equal(0, stack.Minimum);
        }

        [Fact]
        public void PopTest()
        {
            MinStack<int> stack = new();
            stack.Push(12);
            stack.Push(5667);
            stack.Push(2);
            stack.Push(-1);

            Assert.Equal(4, stack.Count);

            stack.Pop();

            Assert.Equal(3, stack.Count);

            stack.Pop();
            stack.Pop();
            stack.Pop();

            Assert.Equal(0, stack.Count);

            stack.Pop();

            Assert.Equal(0, stack.Count);
        }

        [Fact]
        public void MinimumTest()
        {
            MinStack<int> stack = new();
            stack.Push(12);
            stack.Push(5667);
            stack.Push(2);
            stack.Push(-1);

            Assert.Equal(-1, stack.Minimum);

            stack.Pop();

            Assert.Equal(2, stack.Minimum);
        }
    }
}


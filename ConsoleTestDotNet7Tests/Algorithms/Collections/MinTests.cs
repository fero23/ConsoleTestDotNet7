using ConsoleTestDotNet7.Algorithms.Collections;

namespace ConsoleTestDotNet7Tests.Algorithms.Collections
{
	public class MinTests
	{
        /// <summary>
        /// Test that the Push method ads the value to the internal buffer
        /// and increases both the Count and the Capacity.
        /// </summary>
		[Fact]
		public void PushTest()
		{
			MinStack<int> stack = new();

            Assert.Equal(0, stack.Capacity);

            stack.Push(12);
            stack.Push(5667);

            Assert.Equal(2, stack.Capacity);


            stack.Push(2);
            stack.Push(-1);

            Assert.Equal(4, stack.Capacity);

            Assert.Equal(4, stack.Count);
			Assert.Equal(-1, stack.Minimum);
        }

        /// <summary>
        /// Check thatthe default Minimum value of the Stack is the default
        /// value of the generic parameter.
        /// </summary>
        [Fact]
        public void DefaultStateTest()
        {
            MinStack<int> stack = new();
            Assert.Equal(default(int), stack.Minimum);
        }

        /// <summary>
        /// Check that the Pop method returns the last values added to the
        /// stack in LIFO order and that the Count decreases.
        /// </summary>
        [Fact]
        public void PopTest()
        {
            MinStack<int> stack = new();
            stack.Push(12);
            stack.Push(5667);
            stack.Push(2);
            stack.Push(-1);

            Assert.Equal(4,    stack.Count);

            Assert.Equal(-1,   stack.Pop());

            Assert.Equal(3,    stack.Count);

            Assert.Equal(2,    stack.Pop());
            Assert.Equal(5667, stack.Pop());
            Assert.Equal(12,   stack.Pop());

            Assert.Equal(0,    stack.Count);

            Assert.Equal(default(int), stack.Pop());

            Assert.Equal(0, stack.Count);
        }

        /// <summary>
        /// Check that the minimum value is recalculated correctly between
        /// Push and Pop operations.
        /// </summary>
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

        /// <summary>
        /// Check that the capacity of the internal buffer is doubled when
        /// adding values that are higher than the current capacity.
        /// </summary>
        [Fact]
        public void CapacityTest()
        {
            for (int capacity = 2; capacity <= 128; capacity *= 2)
            {
                MinStack<int> stack = new();
                Assert.Equal(0, stack.Capacity);
                for (int i = 0; i < capacity; ++i)
                {
                    stack.Push(i);
                }
                Assert.Equal(capacity, stack.Capacity);
            }
        }
    }
}


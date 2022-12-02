using System;
using System.Xml.Linq;

namespace ConsoleTestDotNet7.Algorithms.Collections
{
	public class MinStack<T> where T : IComparable
	{
		public int Count { get; private set; } = 0;

		private T[]? _buffer = default(T[]?);

		public T? Minimum { get; set; }

		public void Push(T element)
		{
			if (_buffer == null || _buffer.Length < Count + 1)
			{
				RealocateBuffer();
			}

			_buffer![Count] = element;

			Count += 1;

			if (Minimum == null || Minimum.CompareTo(element) > 0)
			{
				Minimum = element;
			}
		}

		public void Pop()
		{
			if (Count > 0)
			{
                Count -= 1;
				if (Count > 1)
				{
					Minimum = _buffer![0];
                    for (int i = 0; i < Count; ++i)
                    {
                        if (Minimum.CompareTo(_buffer[i]) > 0)
                        {
                            Minimum = _buffer[i];
                        }
                    }
                }
				else
				{
					Minimum = default(T);
				}
            }
		}

		private void RealocateBuffer()
		{
			var length = Count == 0 ? 2 : Count * 2;

            var newBuffer = new T[length];
			if (_buffer != null)
			{
				for (int i = 0; i < _buffer.Length; ++i)
				{
					newBuffer[i] = _buffer[i];
				}
			}

			_buffer = newBuffer;
		}
	}
}
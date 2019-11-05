using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
	public class CustomStack<T> : IEnumerable<T>
	{
		private List<T> elements;

		public int Count => elements.Count;

		public CustomStack(params T[] elements)
		{
			this.elements = new List<T>(elements);
		}

		public void Push(params T[] elements)
		{
			elements = elements.Reverse().ToArray();
			this.elements.InsertRange(0, elements);
		}

		public void Pop()
		{
			if (elements.Count == 0)
			{
				throw new InvalidOperationException();
			}

			this.elements.RemoveAt(0);
		}

		public IEnumerator<T> GetEnumerator()
		{
			foreach (var element in elements)
			{
				yield return element;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

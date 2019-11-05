using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIteratos
{
	public class ListyIterator<T> : IEnumerator<T>
	{
		private List<T> elements;
		private int index;

		public ListyIterator(params T[] elements)
		{
			this.elements = new List<T>(elements);
			index = 0;
		}

		public bool MoveNext()
		{

			if (index + 1 < elements.Count)
			{
				index++;
				return true;
			}

			return false;
		}

		public bool HasNext()
		{
			if (index + 1 < elements.Count)
			{
				return true;
			}

			return false;
		}

		public void Reset()
		{
			index = 0;
		}

		public T Current => elements[index];

		object IEnumerator.Current => Current;

		public void Dispose()
		{
		}

		public string Print()
		{
			if (index >= elements.Count)
			{
				return "Invalid Operation!";
			}

			return elements[index].ToString();
		}
	}
}

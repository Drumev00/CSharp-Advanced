using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
	public class Lake : IEnumerable<int>
	{
		private List<int> stones;

		public Lake(params int[] elements)
		{
			this.stones = new List<int>(elements);
		}


		public IEnumerator<int> GetEnumerator()
		{
			var oddPositions = new List<int>();
			var evenPositions = new List<int>();

			for (int i = 0; i < stones.Count; i++)
			{
				if (i % 2 == 0)
				{
					evenPositions.Add(stones[i]);
				}
				else
				{
					oddPositions.Add(stones[i]);
				}
			}

			foreach (var stone in evenPositions)
			{
				yield return stone;
			}

			oddPositions.Reverse();

			foreach (var stone in oddPositions)
			{
				yield return stone;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}

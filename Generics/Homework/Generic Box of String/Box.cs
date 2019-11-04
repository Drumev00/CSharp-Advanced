using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Box_of_String
{
	public class Box<T>
	{
		public T Name { get; set; }

		public override string ToString()
		{
			return $"{Name.GetType()}: {Name}";
		}
	}
}


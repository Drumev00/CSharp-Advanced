﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
	public class Book : IComparable<Book>
	{
		public string Title { get; set; }
		public int Year { get; set; }
		public List<string> Authors { get; private set; }

		public Book(string title, int year, params string[] authors)
		{
			Title = title;
			Year = year;
			Authors = new List<string>();
			Authors.AddRange(authors);
		}

		public int CompareTo(Book other)
		{
			if (Year != other.Year)
			{
				return Year - other.Year;
			}
			return Title.CompareTo(other.Title);
		}

		public override string ToString()
		{
			return $"{Title} - {Year}";
		}
	}
}

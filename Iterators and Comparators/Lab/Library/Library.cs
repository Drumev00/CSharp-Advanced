using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
	public class Library : IEnumerable<Book>
	{
		private List<Book> books;

		private class LibraryIterator : IEnumerator<Book>
		{
			private List<Book> books;
			private int currentIndex;

			public LibraryIterator(IEnumerable<Book> books)
			{
				Reset();
				this.books = new List<Book>(books);
			}
			public Book Current => books[currentIndex];

			object IEnumerator.Current => Current;

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return ++currentIndex < books.Count;
			}

			public void Reset()
			{
				this.currentIndex = -1;
			}
		}

		public Library(params Book[] books)
		{
			this.books = new List<Book>(books);
		}
		public IEnumerator<Book> GetEnumerator()
		{
			return new LibraryIterator(books);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

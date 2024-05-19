using System.Collections;

namespace bookstuff
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library library = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }

        private class Library : IEnumerable<Book>
        {
            private List<Book> books;

            public Library(params Book[] books)

            {
                this.books = new List<Book>(books);
            }

            public IEnumerator<Book> GetEnumerator()

            {
                foreach (var book in this.books)

                {
                    yield return book;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()

            {
                return this.GetEnumerator();
            }
        }

        private class Book
        {
            private string title;

            private int year;

            public IReadOnlyList<string> authors;

            public Book(string title, int year, params string[] authors)

            {
                this.Title = title;

                this.Year = year;

                this.Authors = authors;
            }

            public IReadOnlyList<string> Authors { get; private set; }

            public string Title

            {
                get { return title; }

                private set { title = value; }
            }

            public int Year

            {
                get { return year; }

                private set { year = value; }
            }

            public override string ToString()

            {
                return $"{this.Title} - {this.Year} Authors: {string.Join(", ", this.Authors)}";
            }
        }
    }
}
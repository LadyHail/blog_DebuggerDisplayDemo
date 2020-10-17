using System.Collections.Generic;
using System.Diagnostics;

namespace DebuggerDisplayAttributeDemo
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        private string DebuggerDisplay
        {
            get { return $"{Id}: {Title} {Author}"; }
        }

        public Book(int id, string title, string author, int pages)
        {
            Id = id;
            Title = title;
            Author = author;
            Pages = pages;
        }
    }

    [DebuggerDisplay("{Count} books")]
    public class Books : List<Book>
    {
    }
}
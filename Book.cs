using System.Diagnostics;

namespace DebuggerDisplayAttributeDemo
{
    [DebuggerDisplay("{Id}; {Pages}", Name = "{Title} / {Author}")]
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public Book(int id, string title, string author, int pages)
        {
            Id = id;
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
}
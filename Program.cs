using System;

namespace DebuggerDisplayAttributeDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var books = new Books
            {
                new Book(0, "First", "A", 50),
                new Book(1, "Second", "B", 100),
                new Book(2, "Third", "C", 150),
                new Book(3, "Fourth", "D", 200),
                new Book(4, "Fifth", "E", 250),
                new Book(5, "Sixth", "F", 300),
                new Book(6, "Seventh", "G", 350),
                new Book(7, "Eighth", "H", 400),
                new Book(8, "Ninth", "I", 450),
            };

            Console.WriteLine(books);
            Console.ReadKey();
        }
    }
}
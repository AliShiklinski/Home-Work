namespace Task_1_05._22._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                static void Main(string[] args)
                {
                    Library library = new Library(10);

                    Book book1 = new Book(1, "The Hobbit", 10.99, "Fantasy");
                    Book book2 = new Book(2, "1984", 8.99, "Dystopian");
                    Book book3 = new Book(3, "The Great Gatsby", 12.99, "Classic");

                    library.AddBook(book1);
                    library.AddBook(book2);
                    library.AddBook(book3);

                    Book Book = library.GetBookById(1);
                    Console.WriteLine(Book.Name);

                    Book = library.GetBookByName("1984");
                    Console.WriteLine(Book.Name);

                    Book[] fantasyBooks = library.GetFilteredBooks("Fantasy");
                    foreach (var book in fantasyBooks)
                    {
                        Console.WriteLine(book.Name);
                    }

                    Book[] books = library.GetFilteredBooks(9.00, 13.00);
                    foreach (var book in books)
                    {
                        Console.WriteLine(book.Name);
                    }
                }
            }
        }
    }
}

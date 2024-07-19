public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("Programming", "John Doe", 300);
        Book book2 = new Book("Design Patterns", "Jane Smith", 250);
        Book book3 = new Book("Algorithms", "Tom Hanks", 400);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("Books with 'Program' in their name:");
        var booksByName = library.FindAllBooksByName("Program");
        foreach (var book in booksByName)
        {
            Console.WriteLine($"{book.Name} - {book.Code}");
        }

        Console.WriteLine("\nBook with code 'PR1':");
        var bookByCode = library.FindBookByCode("PR1");
        if (bookByCode != null)
        {
            Console.WriteLine($"{bookByCode.Name} - {bookByCode.Code}");
        }

        Console.WriteLine("\nBooks with page count between 200 and 350:");
        var booksByPageCount = library.FindAllBooksByPageCountRange(200, 350);
        foreach (var book in booksByPageCount)
        {
            Console.WriteLine($"{book.Name} - {book.PageCount} pages");
        }

        Console.WriteLine("\nRemoving book with code 'PR1'");
        library.RemoveBookByCode("PR1");

        Console.WriteLine("\nAll books in the library:");
        foreach (var book in library.Books)
        {
            Console.WriteLine($"{book.Name} - {book.Code}");
        }
    }
}
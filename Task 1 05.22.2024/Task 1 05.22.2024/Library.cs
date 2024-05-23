namespace Task_1_05._22._2024
{
    public class Library
    {

        private Book[] books;
        private int bookCount;

        public Library(int capacity)
        {
            books = new Book[capacity];
            bookCount = 0;
        }

        public void AddBook(Book book)
        {
            if (bookCount >= books.Length)
               
            books[bookCount++] = book;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public Book GetBookByName(string name)
        {
            return books.FirstOrDefault(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public Book[] GetFilteredBooks(string genre)
        {
            return books.Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToArray();
        }

        public Book[] GetFilteredBooks(double Price, double Price2)
        {
            return books.Where(b => b.Price >= Price && b.Price <= Price).ToArray();
        }
    }
}


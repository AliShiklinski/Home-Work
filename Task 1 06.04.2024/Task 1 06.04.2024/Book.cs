using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public string Code { get; private set; }

    private static int _count = 0;

    public Book(string name, string authorName, int pageCount)
    {
        Name = name;
        AuthorName = authorName;
        PageCount = pageCount;
        _count++;
        Code = GenerateCode(name, _count);
    }

    private string GenerateCode(string name, int count)
    {
        return name.Substring(0, 2).ToUpper() + count;
    }
}

public class Library
{
    private List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public List<Book> FindAllBooksByName(string value)
    {
        return Books.Where(b => b.Name.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public Book FindBookByCode(string code)
    {
        return Books.FirstOrDefault(b => b.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
    }

    public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
    {
        return Books.Where(b => b.PageCount >= minPageCount && b.PageCount <= maxPageCount).ToList();
    }

    public void RemoveBookByCode(string code)
    {
        var bookToRemove = Books.FirstOrDefault(b => b.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
        }
    }
}
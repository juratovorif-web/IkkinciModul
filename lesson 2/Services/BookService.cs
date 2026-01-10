
using lesson_2.Models;

namespace lesson_2.Services;

internal class BookService
{
        public List<Book> Books = new List<Book>();
        
    public Guid AddBook(Book book)
    {
        book.BookId = Guid.NewGuid();
        book.Created = DateTime.UtcNow;
        Books.Add(book);
        return book.BookId;
    }
    public Guid DeleteBook(Guid bookId)
    {
        Book book = null;
        foreach (var b in Books)
        {
            if(b.BookId == bookId)
            {
                book = b;
                break;
            }
        }
        if(book != null)
        {
            Books.Remove(book);
            return bookId;
        }
        return Guid.Empty;
    }
    public List<Book> GetAllBooks()
    {
        return Books;
    }

    public void UpdateBook(Book updateBook)
    {
        Book existingBook = null;
        foreach(var b  in Books)
        {
            if(b.BookId == updateBook.BookId)
            {
                existingBook = b;
                break;
            }
        }
        if(existingBook != null)
        {
            existingBook.Title = updateBook.Title;
            existingBook.Author = updateBook.Author;
            existingBook.Price = updateBook.Price;
            existingBook.Description = updateBook.Description;
            existingBook.Created = DateTime.UtcNow;
            existingBook.Genre = updateBook.Genre;  
            existingBook.PageCount = updateBook.PageCount;
        }
    }
    public Book GetById(Guid bookId)
    {
        Book book = null;
        foreach (var b in Books)
        {
            if(b.BookId == bookId)
            {
                book = b;
                break;
            }
        }
        return book;
    }

}

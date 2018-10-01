using SmartMe.Core.Domain.Books;
using System.Collections.Generic;

namespace SmartMe.Services.Books
{
  public interface IBookService
  {
    Book GetBookById(int bookid);
    Book GetBookByISBN(string isbn);
    void DeleteBook(Book Book);
    IList<Book> GetAllBooks();
    void InsertBook(Book Book);
    void UpdateBook(Book Book);
  }
}
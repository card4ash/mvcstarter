using SmartMe.Core.Data;
using SmartMe.Core.Domain.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMe.Services.Books
{
  public class BookService:IBookService
  {
    #region Fields

    private readonly IRepository<Book> _bookRepository;

    #endregion
    #region Ctor

    public BookService(IRepository<Book> bookRepository)
    {
      this._bookRepository = bookRepository;
    }

    public void DeleteBook(Book book)
    {
      if (book == null)
        throw new ArgumentNullException("book");

      _bookRepository.Delete(book);
    }

    public IList<Book> GetAllBooks()
    {
      return _bookRepository.Table.ToList();
    }

    public Book GetBookById(int bookid)
    {
      throw new NotImplementedException();
    }

    public Book GetBookByISBN(string isbn)
    {
      throw new NotImplementedException();
    }

    public void InsertBook(Book Book)
    {
      throw new NotImplementedException();
    }

    public void UpdateBook(Book Book)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}

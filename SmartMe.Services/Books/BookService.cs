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

    #endregion
  }
}

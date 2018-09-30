using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMe.Core.Domain.Books
{
  public class Book : BaseEntity
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public DateTime Published { get; set; }
  }
}

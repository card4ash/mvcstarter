using SmartMe.Core.Domain.Books;
using SmartMe.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMe.Data.Mappings.Books
{
  public class BookMap : SmartEntityTypeConfiguration<Book>
  {
    public BookMap()
    {
      this.ToTable("Books");
      this.HasKey(a => a.Id);
    }
  }
}

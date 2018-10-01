using SmartMe.Core.Domain.Blogs;
using SmartMe.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMe.Data.Mappings.Blogs
{
  public class BlogMap : SmartEntityTypeConfiguration<Blog>
  {
    public BlogMap()
    {
      this.ToTable("Blogs");
      this.HasKey(a => a.Id);
    }
  }
}

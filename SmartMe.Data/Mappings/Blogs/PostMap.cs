using SmartMe.Core.Domain.Blogs;
using SmartMe.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMe.Data.Mappings.Blogs
{
  public class PostMap : SmartEntityTypeConfiguration<Post>
  {
    public PostMap()
    {
      this.ToTable("Posts");
      this.HasKey(a => a.Id);

      this.HasRequired(a => a.Blog).WithMany().HasForeignKey(x => x.BlogId).WillCascadeOnDelete(false);
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMe.Core.Domain.Blogs
{
  public class Blog:BaseEntity
  {
    public string Url { get; set; }
    public int Rating { get; set; }
    public virtual List<Post> Posts { get; set; }
  }
}

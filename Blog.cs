using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Application
{
    public class Blog
    { public int BlogId { get; set; }
        public string? BlogName { get; set; }
        public ICollection<Post>? Posts { get; set; }
    }
}

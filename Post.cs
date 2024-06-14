using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Application
{
    public class Post
    {

        //Scalar properties
        public int PostId { get; set; } //primary key
        public string? PostName { get; set; }
        public int BlogId { get; set; } //foriegn key
        
        // navigation properties
        public Blog? blog { get; set; }

        public ICollection<Comment>? comments { get; set; }
    }
}

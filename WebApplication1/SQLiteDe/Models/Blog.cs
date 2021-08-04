using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteDe.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public string Remark { get; set; }
        public string Remark1 { get; set; }
        
        public ICollection<Post> Posts { get; set; }
    }
}

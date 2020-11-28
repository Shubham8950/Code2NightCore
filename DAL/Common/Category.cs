using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code2Night.DAL.Common
{
    public class Category
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }
    }

    public class Topics
    {
        public int categoryid { get; set; }
        public string topicid { get; set; }
        public string title { get; set; }
        public string topicurl { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
    }
}

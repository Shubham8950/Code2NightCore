using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Code2Night.DAL.Common
{
    public class Article
    {
        public int articleid { get; set; }
        public int topicid { get; set; }
        public string articletitle { get; set; }
        public string article { get; set; }
        public string articleurl { get; set; }
        public int BlogId { get; set; }
        public string TopicArticleDate { get; set; }

        public string topicArticleIntroduction { get; set; }
        public List<Blog> blogs { get; set; }
        public List<Tutorial> tutorials { get; set; }
        [AllowHtml]
        public string ArticleBody { get; set; }
        public string Topictitle { get; set; }

    }
}



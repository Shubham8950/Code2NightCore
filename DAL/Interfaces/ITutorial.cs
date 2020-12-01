using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code2Night.DAL.Common;

namespace Code2Night.DAL.Interfaces
{
    public interface ITutorial
    {
        List<Tutorial> TutorialsList();
        List<Article> ArticleList(string blogUrl);
        Article Article(int blogUrl);
        DataSet ArticleByUrl(string topicUrl,string articleUrl);
        string InsertCategory(Category category);
        string InsertTopic(Topics topic);
        List<Category> GetCategories();
        List<Topics> GetTopics();
        string InsertArticle(Article article);
        List<Article> GetArticles();
    }
}

using System;
using System.Collections.Generic;
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
       string InsertCategory(Category category);
    }
}

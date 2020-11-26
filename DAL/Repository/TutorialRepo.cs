using System;
using System.Collections.Generic;
using System.Linq;

using Code2Night.DAL.Interfaces;
using Code2Night.DAL.Common;
using Dapper;

namespace Code2Night.DAL.Repository
{
    public class TutorialRepo : GenericMasterRepo<Article>, ITutorial
    {
        public List<Tutorial> TutorialsList()
        {
            var DynamicParameter = new DynamicParameters();
            var getAllCategoryList = GetTableById("GetAllCategoryList", "").DataTableToList<Tutorial>();
            return getAllCategoryList.ToList();
        }

        public List<Article> ArticleList(string blogUrl)
        {
            var DynamicParameter = new DynamicParameters();
            DynamicParameter.Add("@topicUrl", blogUrl);
            var blog = GetList("GetTutorialbyid", DynamicParameter);
            return blog.ToList();
        }

        public Article Article(int id)
        {
            var DynamicParameter = new DynamicParameters();
            DynamicParameter.Add("@id", id);
            var blog = GetList("GetArticle", DynamicParameter);
            return blog.ToList().FirstOrDefault();
        }

        public string InsertCategory(Category category)
        {
            var DynamicParameter = new DynamicParameters();
            DynamicParameter.Add("@categoryname", category.categoryname);
            string existsornot = Insert("insertcategory", DynamicParameter);
            return existsornot;

        }
    }
}
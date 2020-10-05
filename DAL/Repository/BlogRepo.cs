using System;
using System.Collections.Generic;
using System.Linq;
using Code2Night.DAL.Interfaces;
using Code2Night.DAL.Common;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace Code2Night.DAL.Repository
{
    public class BlogRepo :GenericMasterRepo<Blog>, IBlog
    {
        public List<Blog> GetBlogs()
        {
            var DynamicParameter = new DynamicParameters();
            DynamicParameter.Add("@Activity", "ListBlogFile");
            var blog = GetList("sprBlogs", DynamicParameter);
            return blog.ToList();
        }

        public List<Blog> GetFilterBlog(int? pageNumber=1, int pageSize=3,string search="", bool IsFilter=false)
        {
            var DynamicParameter = new DynamicParameters();
            DynamicParameter.Add("@pageSize", pageSize);
            DynamicParameter.Add("@IsFilter", IsFilter);
            DynamicParameter.Add("@pageNumber", pageNumber);
            DynamicParameter.Add("@search", search);
            var blog = GetList("sprBlogFilter", DynamicParameter);
            return blog.ToList();
        }

        public Blog GetBlogsById(int Id)
        {
            return GetTableById("sprBlogs", "BlogsById", Id).DataTableToList<Blog>().FirstOrDefault();
        }

        public void BlogDelete(int Id)
        {
            Connection.Delete(Id, "sprBlogs", "Delete", "Id");
        }

        public List<Blog> GetMyBlogs(Users user)
        {
            var DynamicParameter =new DynamicParameters();
            DynamicParameter.Add("@Activity", "BlogsByUser");
            DynamicParameter.Add("@UserId", user.UserID);
            var myblog = GetList("sprBlogs", DynamicParameter);
            return myblog.ToList();
        }

        public List<Tag> Tag()
        {
            return GetTableById("sprTags", "List").DataTableToList<Tag>();
        }

        public Blog BlogDetail(string name)
        {
            var DynamicParameter = new DynamicParameters();
            DynamicParameter.Add("@Activity", "BlogsByURL");
            DynamicParameter.Add("@BlogUrl", name);
            var blog = GetList("sprBlogs", DynamicParameter);
            return blog.ToList().FirstOrDefault();
        }

        public string AddBlog(Blog blog)
        {
            var adp = new SqlDataAdapter("sprBlogs",Connection.sqlConStr);
            adp.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Activity",blog.Id>0?"Edit":"Add");
            adp.SelectCommand.Parameters.AddWithValue("@BlogUrl", blog.BlogUrl);
            adp.SelectCommand.Parameters.AddWithValue("@UserID", blog.User.Id);
            adp.SelectCommand.Parameters.AddWithValue("@BlogMonth", blog.BlogMonth);
            adp.SelectCommand.Parameters.AddWithValue("@BlogBody", blog.BlogBody);
            adp.SelectCommand.Parameters.AddWithValue("@Title", blog.Title);
            adp.SelectCommand.Parameters.AddWithValue("@Categories", blog.Categories);
            adp.SelectCommand.Parameters.AddWithValue("@Tags", blog.Tags);
            adp.SelectCommand.Parameters.AddWithValue("@BlogIntroduction", blog.BlogIntroduction);
            adp.SelectCommand.Parameters.AddWithValue("@Document", blog.Document);
            adp.SelectCommand.Parameters.AddWithValue("@VideoEmbed", blog.VideoEmbed);
            adp.SelectCommand.Parameters.AddWithValue("@Id", blog.Id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return Convert.ToString( dt.Rows[0][0]);
        }

        public List<EmployeeDashboard> EmployeeDashboards()
        {
          return  GetTableById("TrafficWeeklyGraph","").DataTableToList<EmployeeDashboard>();
        }

        public DashBoardCount EmployeeDashboardsCount()
        {
            return GetTableById("sprDashBoardView", "").DataTableToList<DashBoardCount>().FirstOrDefault();
        }

        public string AddItem(TodoItem toDoItem)
        {
            var com = new SqlCommand("TaskToDos");
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@TaskName", toDoItem.TaskName);
            return Connection.ExecuteNonQuery(com);
        }

        public List<TodoItem> GetToDo()
        {
            return GetTableById("GetToDo", "").DataTableToList<TodoItem>();
        }

        public string SaveUpdateItem(TodoItem todoItem)
        {
            if (todoItem.IsCompleted)
            {
            }
            var com = new SqlCommand("SaveUpdateItem");
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", todoItem.Id);
            com.Parameters.AddWithValue("@IsCompleted", todoItem.IsCompleted);
            return Connection.ExecuteNonQuery(com);
        }
    }
}
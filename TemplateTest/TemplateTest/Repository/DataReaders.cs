using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TemplateTest.Models;

namespace TemplateTest.Repository
{
    public class DataReaders
    {
        public ArticleModel GetArticleModel(string title)
        {
            PostModel postModel = null;
            Collection<string> comments = null;

            using(var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand("SELECT * FROM POST WHERE Title = @title"))
                {
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("title", title));
                    using (var reader = command.ExecuteReader()) 
                    {
                        if (reader.Read())
                        {
                            postModel = new PostModel(
                                reader["Title"].ToString(),
                                reader["Body"].ToString(),
                                DateTime.Parse(reader["DateCreated"].ToString())
                                );
                        }
                    }
                }

                using (var command = new SqlCommand("SELECT Comment.* FROM Comment INNER JOIN Post ON Comment.PostID = Post.PostID WHERE Post.Title = @title"))
                {
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("title", title));
                    comments = new Collection<string>();
                    using (var dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            comments.Add(dataReader["Body"].ToString());
                        }
                    }
                }
            }

            return new ArticleModel(postModel, comments);
        }

        public void AddComment(string title, string comment)
        {
            using (var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString))
            {
                using (var sqlCommand = new SqlCommand(@"INSERT INTO Comment
	            SELECT PostID, @comment AS MyPost 
                FROM Post 
                WHERE Title = @title"))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("comment", comment));
                    sqlCommand.Parameters.Add(new SqlParameter("title", title));
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
} 
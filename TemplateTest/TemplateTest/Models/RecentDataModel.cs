using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using TemplateTest.Repository;

namespace TemplateTest.Models
{
    public class RecentDataModel
    {
        public RecentDataModel()
        {
            Items = new Collection<RecentDataItemModel>();
            for (int i = 0; i < 3; i++ )
            {
                using (var ctx = new EFContext())
                {
                    var post = ctx.Posts.FirstOrDefault();
                    
                    var postModel = new RecentDataItemModel(post.Title, post.PostID, post.DateCreated);
                    Items.Add(postModel);
                }
            }          
        }

        public ICollection<RecentDataItemModel> Items { get; set; }
    }
}
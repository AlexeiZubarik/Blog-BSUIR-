using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest.Models
{
    public class RecentDataItemModel
    {
        public RecentDataItemModel()
        {
            Text = "Some recent data text";
            URL = "http://vk.com";
            Date = DateTime.Now.AddDays(-1);

        }

        public string Text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
    }
}
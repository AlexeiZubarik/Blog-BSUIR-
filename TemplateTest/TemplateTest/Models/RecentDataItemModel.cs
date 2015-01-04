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
            ID = new Random(99).Next(1, 9999);
            Date = DateTime.Now.AddDays(-1);
        }

        public string Text { get; set; }
        public int ID { get; set; }
        public DateTime Date { get; set; }
    }
}
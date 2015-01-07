using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest.Models
{
    public class RecentDataItemModel
    {
        private readonly string text;
        private readonly int id;
        private readonly DateTime date;

        public RecentDataItemModel(string text,int id, DateTime date)
        {
            this.text = text;
            this.id = id;
            this.date = date;
        }

        public string Text 
        {
            get { return text; }
        }

        public int ID
        {
            get { return id; }
        }

        public DateTime Date
        {
            get { return date; }
        }        
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateTest.Models
{
    public class AddCommentModel
    {
        public string Comment{ get; set; }

        public UserModel User { get; set; }
        
    }
}

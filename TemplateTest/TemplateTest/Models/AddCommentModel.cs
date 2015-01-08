using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateTest.Models
{
    public class AddCommentModel
    {
        [Required(ErrorMessage = "Пожалуйста, введите {0}!")]
        [Display (Name ="Комментарий")]
        public string Comment{ get; set; }
        //public UserModel User { get; set; }        
    }
}

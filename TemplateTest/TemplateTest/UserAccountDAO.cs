using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest
{
    public class UserAccountDAO
    {
        public UserAccount GetUserAccount(string UserName)
        {
            return new UserAccount() { UserName = UserName, Password = "SecretString"};
        }
    }
}
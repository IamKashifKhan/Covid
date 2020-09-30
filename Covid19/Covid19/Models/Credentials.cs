using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models
{
    public class Credentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public Credentials(string user, string pass)
        {
            UserName = user;
            Password = pass;
        }
    }
}

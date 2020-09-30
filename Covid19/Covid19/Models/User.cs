using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models
{
    public class User
    {
        public class AuthenticatUser
        {
            public string status { get; set; }
            public Data data { get; set; }

        }
        public class Data
        {
            public string id { get; set; }
            public string name { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string role { get; set; }
            public string districtId { get; set; }
            public string districtName { get; set; }
        }
    }
   


}

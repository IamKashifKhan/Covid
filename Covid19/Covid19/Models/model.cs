using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models
{
   public  class model
    {
        public class District
        {
            public string id { get; set; }
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Gender
        {
            public int id { get; set; }
            public string name { get; set; }
            public string value { get; set; }
        }

        public class ReasonForTest
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Data
        {
            public List<District> district { get; set; }
            public List<Gender> gender { get; set; }
            public List<ReasonForTest> reasonForTest { get; set; }
        }

        public class RootObject
        {
            public string status { get; set; }
            public string message { get; set; }
            public Data data { get; set; }
        }
        public class LoginRoot
        {
            public string status { get; set; }
            public Data data { get; set; }
        }
    }
}

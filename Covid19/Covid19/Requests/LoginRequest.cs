using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Requests
{
    public class LoginRequest
    {


       // [AliasAs("email")]
        [JsonProperty(PropertyName = "email")]
        public string email { get; }

      //  [AliasAs("password")]
        [JsonProperty(PropertyName = "password")]
        public string password { get; }

        public LoginRequest(string userName, string Password)
        {
            email = userName;
            password = Password;
        }
    }


    public class P_Data_Request
    {


        // [AliasAs("email")]
        [JsonProperty(PropertyName = "districtId")]
        public string districtId { get; }

        //  [AliasAs("password")]
        

        public P_Data_Request(string D_ID)
        {
            districtId = D_ID;
        }
    }

}

using Covid19.Requests;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.Services
{
    [Headers("Accept: application/json")]
    public interface ICovidApi
    {
        [Post("app/Login/checkLogin")]
        Task<string> Login([Body(BodySerializationMethod.UrlEncoded)] LoginRequest login);

        
    }
}
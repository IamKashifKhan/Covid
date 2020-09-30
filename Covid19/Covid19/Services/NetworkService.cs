using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Services
{
    public static class NetworkService
    {
        public static IApiService apiService;
        static string baseUrl = "http://covid19.sindhmonitoringcell.com";
    public static IApiService GetApiService()
        {
            apiService = RestService.For<IApiService>(baseUrl);
            return apiService;
        }
    }
}

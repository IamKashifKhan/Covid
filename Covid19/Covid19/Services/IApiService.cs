using Covid19.Models;
using Covid19.Requests;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Covid19.Models.ApiResults;

namespace Covid19.Services
{
    [Headers("Accept: application/json")]

    public interface IApiService
    {
        [Get("/app/Patient/patientRegistrationData")]
        Task<string> GetPost();
        [Post("/app/Patient/getAllPatients")]
        Task<string> GetAllPatientData([Body(BodySerializationMethod.Serialized)] P_Data_Request login);



        [Post("/app/Login/checkLogin")]
        Task<string> Login([Body(BodySerializationMethod.Serialized)] LoginRequest login);

    }
}

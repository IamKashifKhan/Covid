using Covid19.Models;
using Covid19.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using static Covid19.Models.DistrictPatientData;

namespace Covid19.Views
{
    public partial class AssessmentPage : ContentPage
    {
        public List<Datum> DistrictListdata = new List<Datum>();
        public AssessmentPage()
        {
            NavigationPage.SetHasNavigationBar (this, false);
            InitializeComponent();
            GetPatientdata();
        }

        private async void GetPatientdata()
        {
            var P_req = new Requests.P_Data_Request("20");
            var Apiservice = NetworkService.GetApiService();
            var apiresponse = await Apiservice.GetAllPatientData(P_req);
            var kkk = JsonConvert.DeserializeObject<Districtpatient>(apiresponse);
            DistrictListdata = kkk.data;
            DPLvu.ItemsSource = null;
            DPLvu.ItemsSource = DistrictListdata;
        }
    }
}

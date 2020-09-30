using Covid19.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using static Covid19.Models.model;

namespace Covid19.Views
{
    public partial class RegistrationPage : ContentPage
    {
        public List<District> Districtdata = new List<District>();
        public List<Gender> Gender = new List<Gender>();
        public List<ReasonForTest> ReasonForTest = new List<ReasonForTest>();
        //private List<District> _districtdata;
        //public List<District> Districtdata
        //{
        //    get { return _districtdata; }
        //    set { SetProperty(ref _districtdata, value, nameof(Districtdata)); }
        //}
        //private List<Gender> _gender;
        //public List<Gender> Gender
        //{
        //    get { return _gender; }
        //    set { SetProperty(ref _gender, value, nameof(Gender)); }
        //}
        //private List<ReasonForTest> _reasonForTest;
        //public List<ReasonForTest> ReasonForTest
        //{
        //    get { return _reasonForTest; }
        //    set { SetProperty(ref _reasonForTest, value, nameof(Gender)); }
        //}
        public RegistrationPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
            GetPatientRegistrationData();
        }
        private async void GetPatientRegistrationData()
        {
            var Apiservice = NetworkService.GetApiService();
            var apiresponse = await Apiservice.GetPost();
            var kkk = JsonConvert.DeserializeObject<RootObject>(apiresponse);
            var apidata = kkk.data;
            Districtdata = apidata.district;
            Gender = apidata.gender;
            ReasonForTest = apidata.reasonForTest;

            Genderpicker.ItemsSource = Gender.Select(g => g.name).ToList();
            Districtpicker.ItemsSource = Districtdata.Select(g => g.name).ToList();
            Reasonpicker.ItemsSource = ReasonForTest.Select(g => g.name).ToList();

        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}

using Covid19.Models;
using Covid19.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Covid19.Models.model;

namespace Covid19.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
       
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var Apiservice = NetworkService.GetApiService();

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();


            var razaeq = new Requests.LoginRequest("dccentral.cmh@gmail.com", "63261");
             
            
 
          

            var jjjj = await Apiservice.Login(razaeq);

         }
    }
}
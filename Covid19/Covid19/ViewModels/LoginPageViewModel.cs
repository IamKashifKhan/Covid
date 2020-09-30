using Covid19.Models;
using Covid19.Services;
using Covid19.Views;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static Covid19.Models.ApiResults;
using static Covid19.Models.User;

namespace Covid19.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private bool isalreadylogin;
        public ICommand GotoTaskSelection { get; set; }
        public ICommand SubmitCommand { get; }

        private string _username;
        public string UserName
        {
            get { return _username; }
            set { SetProperty(ref _username, value, nameof(UserName)); }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value, nameof(Password)); }
        }
        private readonly IPageDialogService dialogService;
        private readonly IApiService Apiservice;
        public LoginPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
            : base(navigationService)
        {
            this.dialogService = dialogService;
            SubmitCommand = new Command(Submit);
            Apiservice = NetworkService.GetApiService();
            GotoTaskSelection = new Command(() =>
            {
                GotoTaskSelectionPage();
            });
            ValidateLoginFromDB();
        }

        private async void ValidateLoginFromDB()
        {
            try
            {
                //For ISQLITE
                var UserCredentials = await App.Database.GetLoggedinUser();

                foreach (var dataItem in UserCredentials)
                {
                    UserName = dataItem.email;
                    Password = dataItem.password;
                    isalreadylogin = true;
                }


            }
            catch
            {

            }

        }


        private async void Submit(object obj)
        {


            if (string.IsNullOrWhiteSpace(UserName))
            {
                await dialogService.DisplayAlertAsync("Alert", "Please provide Username", "cancel");
            }
            if (string.IsNullOrWhiteSpace(Password))
            {
                await dialogService.DisplayAlertAsync("Alert", "Please provide Password", "cancel");
            }

            AuthenticatUser result = null;
            try
            {
                var credentials = new Requests.LoginRequest(UserName, Password);
                var apiresult = await Apiservice.Login(credentials);
                result = JsonConvert.DeserializeObject<AuthenticatUser>(apiresult);

            }
            catch (Exception ex)
            {
                var action = dialogService.DisplayAlertAsync("Alert", ex.Message, "OK");
            }

            if (result != null && result.status == "success")
            {
                if (!isalreadylogin)
                {
                    App.Database.AddLoggedinUser(UserName, Password);
                }
                await this.NavigationService.NavigateAsync($"{nameof(TaskSelectionPage) }");
            }
        }
        private async void GotoTaskSelectionPage()
        {
            await this.NavigationService.NavigateAsync($"{nameof(TaskSelectionPage) }");
        }
    }
}

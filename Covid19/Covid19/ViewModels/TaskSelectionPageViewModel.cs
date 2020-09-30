using Covid19.Services;
using Covid19.Views;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Covid19.ViewModels
{
    public class TaskSelectionPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public ICommand SelectedTask { get; set; }
        public ICommand LogoutCommand { get; set; }

        private readonly IApiService Apiservice;

        private string  myProperty;
        public string  MyProperty { 
            get { return myProperty; } 
            set { SetProperty(ref myProperty, value, OnMyPropertyChaged); }
        }

        private async  void OnMyPropertyChaged()
        {
            if (MyProperty == "0")
            {
                await this.NavigationService.NavigateAsync($"NavigationPage/{nameof(RegistrationPage)}");

            }
            else if (MyProperty == "1")
            {
                await this.NavigationService.NavigateAsync($"NavigationPage/{nameof(AssessmentPage)}");
            }
               
        }

 
        public TaskSelectionPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            LogoutCommand = new Command(() =>
            {
                logoutCommand();
            });
           
        }
 
        private async  void logoutCommand()
        {
            await this.NavigationService.NavigateAsync($"{nameof(LoginPage)}");
        }
    }
}

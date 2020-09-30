using Covid19.Services;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using static Covid19.Models.model;

namespace Covid19.ViewModels
{
    public class RegistrationPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private readonly IApiService Apiservice;
        //List<District> Districtdata;
        //List<Gender> gender;
        //List<ReasonForTest> reasonForTest;

       
        public RegistrationPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
          //  GetPatientRegistrationData();
          //  Apiservice = NetworkService.GetApiService();
        }



    }
}

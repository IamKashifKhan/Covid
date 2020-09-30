using Covid19.ViewModels;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskSelectionPage : ContentPage
    {
       // TaskSelectionPageViewModel taskSelectionPageViewModel;
         public TaskSelectionPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
       //     taskSelectionPageViewModel = (TaskSelectionPageViewModel)this.BindingContext;

            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private  void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  taskSelectionPageViewModel.SelectedTask.Execute("Registartion");
           // this.navigationService.NavigateAsync("Navigationpage/AssessmentPage");
        }
    }
}
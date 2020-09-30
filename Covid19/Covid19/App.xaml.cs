using Prism;
using Prism.Ioc;
using Covid19.ViewModels;
using Covid19.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Navigation;
using Covid19.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Covid19
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public static CovidDb _database;

        public static CovidDb Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new CovidDb(DependencyService.Get<IFileHelper>().GetLocalFilePath("Coviddb.db3"));
                }
                return _database;
            }
        }

        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<TaskSelectionPage, TaskSelectionPageViewModel>();
            containerRegistry.RegisterForNavigation<AssessmentPage, AssessmentPageViewModel>();
            containerRegistry.RegisterForNavigation<RegistrationPage, RegistrationPageViewModel>();
            containerRegistry.RegisterSingleton<INavigationService>();
            containerRegistry.RegisterSingleton<IFileHelper>();
            containerRegistry.RegisterSingleton<CovidDb>();
        }
    }
}

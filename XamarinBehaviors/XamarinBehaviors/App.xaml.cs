using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBehaviors.Helpers;
using XamarinBehaviors.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinBehaviors
{
    public partial class App : Application
    {
        public static ViewModels.AddPlanGameViewModel PlayListViewModel { get; set; }

              
        public App()
        {
            InitializeComponent();
            DependencyService.Register<SQLitePlanAGameDatabase>();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

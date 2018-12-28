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
        static SQLItePlanAGameDatabase database;

        public static SQLItePlanAGameDatabase Database
        {
            get
            {
                if (database == null)

                {
                    string localFilePath = DependencyService.Get<IFileHelper>().GetLocalFilePath("TennsGame.db3");
                    database = new SQLItePlanAGameDatabase(localFilePath);
                }


                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            DependencyService.Register<SQLItePlanAGameDatabase>();

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

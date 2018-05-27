using System;
using Xamarin.Forms;
using XamApp1.Services;
using XamApp1.Views;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamApp1
{
	public partial class App : Application
	{
		//TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        public static string AzureBackendUrl = "http://localhost:5000";
        public static bool UseMockDataStore = true;
		
		public App ()
		{
			InitializeComponent();

			if (UseMockDataStore)
				DependencyService.Register<MockDataStore>();
			else
				DependencyService.Register<AzureDataStore>();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            //AppCenter.Start("ios=b78111b3-910a-4e73-8ee9-f388496cc8ca;" +
            //      "uwp={Your UWP App secret here};" +
            //      "android={Your Android App secret here}",
            //      typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

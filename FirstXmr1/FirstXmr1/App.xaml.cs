using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FirstXmr1
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MyPage();
		}

		protected override void OnStart()
		{
			Console.WriteLine("Hello im on start");
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			Console.WriteLine("Hello im on sleep");
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			Console.WriteLine("Hello im on resume");
			// Handle when your app resumes
		}
	}
}

using CrossPlatformSummit.Core.Services;
using CrossPlatformSummit.Core.ViewModels;
using CrossPlatformSummit.Services;
using View;
using Xamarin.Forms;

namespace CrossPlatformSummit
{
	public class App : Application
	{
		public App ()
		{
			var navigationPage = 
				new NavigationPage(
					new View.PalestrantesPage()
				);
			// The root page of your application
			MainPage = navigationPage;

			var navigationService = 
				new NavigationService(navigationPage);

			Core.Services.Services.IoC.Register<INavigationService>(ioc =>
				navigationService);

			navigationService.Register<PalestrantesViewModel, PalestrantesPage>();
			navigationService.Register<PalestranteViewModel, PalestrantePage>();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
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


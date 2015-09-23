using Cirrious.CrossCore.IoC;
using Services.MVVMCross;
using CrossPlatformSummit.Core.Services;

namespace CrossPlatformSummit.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

			var navigationService = 
				new NavigationService();

			Core.Services.Services.IoC.Register<INavigationService>(ioc =>
				navigationService);

			RegisterAppStart<ViewModels.PalestrantesViewModel>();
        }
    }
}
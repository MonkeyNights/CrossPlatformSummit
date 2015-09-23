using System;
using CrossPlatformSummit.Core.Services;
using System.Threading.Tasks;
using Cirrious.CrossCore.Core;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Platform;

namespace Services.MVVMCross
{
	public class NavigationService : INavigationService
	{
		public Task NavigateTo<T> (params object[] parametros)
		{
			var viewDispatcher = (IMvxViewDispatcher)MvxMainThreadDispatcher.Instance;

			if (viewDispatcher != null) {
				return Task.FromResult(viewDispatcher.ShowViewModel (new MvxViewModelRequest (
					typeof(T),
					new MvxBundle(((object)null).ToSimplePropertyDictionary()),
					null,
					null)));
			}

			return Task.FromResult (false);
		}
	}
}


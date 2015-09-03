using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CrossPlatformSummit.Core.Services;
using Xamarin.Forms;

namespace CrossPlatformSummit.Services
{
    public class NavigationService : INavigationService
    {
        private NavigationPage _navigationPage;

        public NavigationService(NavigationPage navigationPage)
        {
            _navigationPage = navigationPage;
        }

        public async Task NavigateTo<T>(params object[] parametros)
        {
            var viewModel = Activator.CreateInstance<T>();

            var viewType = _viewModelToViewDictionary[typeof (T)];

            var view = Activator.CreateInstance(viewType);

            var page = (Page) view;
            page.BindingContext = viewModel;

            await _navigationPage.Navigation.PushAsync(page);
        }

        internal void Register<T, TU>()
        {
            _viewModelToViewDictionary.Add(typeof(T), typeof(TU));
        }

        private readonly Dictionary<Type, Type> _viewModelToViewDictionary = new Dictionary<Type, Type>();
    }
}

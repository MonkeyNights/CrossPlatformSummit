using System.Collections.ObjectModel;
using System.Windows.Input;
using CrossPlatformSummit.Core.Services;

namespace CrossPlatformSummit.Core.ViewModel
{
    public class PalestrantesViewModel
    {
        public ObservableCollection<Model.Palestrante> Palestrantes
        {
            get;
            set;
        }

        public ICommand CarregarCommand
        {
            get;
            set;
        }

        public PalestrantesViewModel()
        {
            Palestrantes = new ObservableCollection<Model.Palestrante>();
            CarregarCommand = new RelayCommand(Carregar);
        }

        private void Carregar()
        {
            var navigationService = Services.Services.IoC.Resolve<INavigationService>();
            navigationService.NavigateTo<PalestranteViewModel>();

            //var quantidade = Palestrantes.Count;
            //Palestrantes.Add (new Model.Palestrante{
            //	Nome = string.Format("Nome {0}", quantidade),
            //	Bio = string.Format("Bio {0}", quantidade),
            //	UrlFoto = "https://avatars3.githubusercontent.com/u/13861424?v=3&s=200"
            //});
        }
    }
}
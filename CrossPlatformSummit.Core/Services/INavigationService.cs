using System.Threading.Tasks;

namespace CrossPlatformSummit.Core.Services
{
    public interface INavigationService
    {
        Task NavigateTo<T>(params object[] parametros);
    }
}

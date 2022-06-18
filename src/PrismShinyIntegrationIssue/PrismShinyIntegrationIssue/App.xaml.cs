using Prism.DryIoc;
using Prism.Ioc;
using Prism.Navigation;
using PrismShinyIntegrationIssue.ViewModels;
using PrismShinyIntegrationIssue.Views;

namespace PrismShinyIntegrationIssue
{
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        protected override async void OnInitialized()
        {
            INavigationResult navResult = await NavigationService.NavigateAsync($"/{nameof(MainPage)}");
        }
    }
}

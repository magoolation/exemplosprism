using Prism.Unity;
using ExemplosPrismForms.Views;
using Xamarin.Forms;

namespace ExemplosPrismForms
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/NavigationServicePage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<EventAggregatorPage>();
            Container.RegisterTypeForNavigation<EventAggregatorDetailPage>();
            Container.RegisterTypeForNavigation<NavigationServicePage>();
            Container.RegisterTypeForNavigation<NavigationModalPage>();
        }
    }
}

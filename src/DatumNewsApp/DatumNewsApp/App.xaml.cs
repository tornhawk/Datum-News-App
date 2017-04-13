using Autofac;
using Prism.Autofac;
using Prism.Autofac.Forms;
using DatumNewsApp.Views;
using Xamarin.Forms;
using DatumNewsApp.Pages;

namespace DatumNewsApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //NavigationService.NavigateAsync("NavigationPage/SwitcherPage");

            var navPage = new NavigationPage(new SwitcherPage())
            {
                Icon = null
            };
            MainPage = navPage;
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SwitcherPage>();

            
        }
    }
}

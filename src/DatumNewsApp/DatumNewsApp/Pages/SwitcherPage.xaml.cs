using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatumNewsApp.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitcherPage : ContentPage
    {
        public SwitcherPage()
        {
            InitializeComponent();

            btnNone.Command = new Command(async (obj) => await Navigation.PushAsync(new MainPage(Controls.CarouselLayout.IndicatorStyleEnum.None)));
            btnDots.Command = new Command(async (obj) => await Navigation.PushAsync(new MainPage(Controls.CarouselLayout.IndicatorStyleEnum.Dots)));
            btnTabs.Command = new Command(async (obj) => await Navigation.PushAsync(new MainPage(Controls.CarouselLayout.IndicatorStyleEnum.Tabs)));
        }
    }

}

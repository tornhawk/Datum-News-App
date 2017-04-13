using DatumNewsApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatumNewsApp.ViewModels
{
    public class HomeViewModel : BaseViewModel, ITabProvider
    {
        public HomeViewModel() { }

        public string Title { get; set; }
        public Color Background { get; set; }
        public string ImageSource { get; set; }
    }
}

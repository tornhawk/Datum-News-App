using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatumNewsApp.ViewModels
{
    public class SwitcherPageViewModel : BaseViewModel
    {
        public SwitcherPageViewModel()
        {
            Pages = new List<HomeViewModel>() {
                new HomeViewModel { Title = "Title 1", Background = Color.White},
                new HomeViewModel { Title = "Title 2", Background = Color.Red},
                new HomeViewModel { Title = "Title 3", Background = Color.Blue },
                new HomeViewModel { Title = "Title 4", Background = Color.Yellow },
            };

            CurrentPage = Pages.First();
        }

        IEnumerable<HomeViewModel> _pages;
        public IEnumerable<HomeViewModel> Pages
        {
            get { return _pages; }
            set
            {

                SetObservableProperty(ref _pages, value);
                CurrentPage = Pages.FirstOrDefault();
            }
        }

        HomeViewModel _currentPage;
        public HomeViewModel CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                SetObservableProperty(ref _currentPage, value);
            }
        }
    }
}

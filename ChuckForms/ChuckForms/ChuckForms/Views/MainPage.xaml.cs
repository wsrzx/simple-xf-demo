using ChuckForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChuckForms.Views
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel _vm;
        public MainViewModel ViewModel
        {
            get
            {
                if (_vm == null)
                    _vm = new MainViewModel();

                if (BindingContext == null)
                    BindingContext = _vm;

                return (BindingContext as MainViewModel);
            }
        }

        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.Initialize(null);
        }
    }
}

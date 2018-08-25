using ChuckForms.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChuckForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JokePage : ContentPage
    {
        private JokeViewModel _vm;
        public JokeViewModel ViewModel
        {
            get
            {
                if (_vm == null)
                    _vm = new JokeViewModel();

                BindingContext = _vm;

                return (BindingContext as JokeViewModel);
            }
        }

        public JokePage()
        {
            InitializeComponent();
        }
    }
}
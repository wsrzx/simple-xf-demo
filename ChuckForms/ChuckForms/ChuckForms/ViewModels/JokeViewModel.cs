using ChuckForms.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ChuckForms.ViewModels
{
    public class JokeViewModel : BaseViewModel
    {
        private string _category;
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value; OnPropertyChanged();
            }
        }

        private Joke _joke = new Joke();
        public Joke Joke
        {
            get
            {
                return _joke;
            }
            set
            {
                _joke = value; OnPropertyChanged();
            }
        }

        public JokeViewModel() : base("")
        {
        }

        public override async Task Initialize(object parameters)
        {
            Category = parameters as string;
            Title = Category;

            await LoadData();
        }

        async Task LoadData()
        {
            if (IsBusy)
                return;

            Exception error = null;

            try
            {
                IsBusy = true;

                var joke = await Api.GetRandomJokeByCategoyAsync(Category);
                Joke = joke;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
                error = ex;
            }
            finally
            {
                IsBusy = false;
            }

            if (error != null)
                await ShowAlertAsync("Error!", error.Message, "OK");
        }
    }
}

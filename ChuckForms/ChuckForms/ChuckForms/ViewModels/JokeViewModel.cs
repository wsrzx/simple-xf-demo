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

        public JokeViewModel() : base("")
        {
        }

        public override async Task Initialize(object parameters)
        {
            Category = parameters as string;
            Title = Category;

            await base.Initialize(parameters);
        }
    }
}

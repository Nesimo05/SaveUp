using System.Windows.Input;

namespace SaveUp.ViewModels
{
    public class AddProductViewModel : BaseViewModel
    {
        private string _description;
        private decimal _price;

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        public decimal Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public ICommand SaveCommand { get; }

        public AddProductViewModel()
        {
            SaveCommand = new Command(OnSave);
        }

        private async void OnSave()
        {
            // Save product logic here
        }
    }
}

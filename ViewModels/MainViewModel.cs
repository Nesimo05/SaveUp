using System.Windows.Input;

namespace SaveUp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand NavigateToAddProductCommand { get; }
        public ICommand NavigateToProductListCommand { get; }

        public MainViewModel()
        {
            NavigateToAddProductCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync(nameof(AddProductPage));
            });

            NavigateToProductListCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync(nameof(ProductListPage));
            });
        }
    }
}

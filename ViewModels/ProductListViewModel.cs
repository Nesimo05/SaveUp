using SaveUp.Properties.Models;
using System.Collections.ObjectModel;

namespace SaveUp.ViewModels
{
    public class ProductListViewModel : BaseViewModel
    {
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }

        public ProductListViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product { Description = "Coffee", Price = 2.5m },
                new Product { Description = "Snack", Price = 1.5m }
            };
        }

        public decimal TotalPrice => Products.Sum(p => p.Price);
    }
}
